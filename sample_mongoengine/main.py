import tornado.httpserver
import tornado.ioloop
import tornado.web
import os
import mongoengine

mongoengine.connect("contacts")

class Contacts(mongoengine.Document):
    email = mongoengine.StringField(primary_key=True, required=True, unique=True)
    lastname = mongoengine.StringField()
    firstname = mongoengine.StringField()
    phone = mongoengine.StringField(max_length=15)

class MainHandler(tornado.web.RequestHandler):
    def get(self):
        self.render("home.html")

class RegisterHandler(tornado.web.RequestHandler):
    def post(self):
        try:
            contact = Contacts(email = self.get_argument("email"))
            contact.lastname = self.get_argument("lastname")
            contact.firstname = self.get_argument("firstname")
            contact.phone = self.get_argument("phone")
            contact.save()
            self.render("register.html", message="The contact has been registered successfully.", text="")
        except:
            self.render("message.html", title="Register contact", message="Uno o mas campos son necesarios para el registro.", text="")

class SearchHandler(tornado.web.RequestHandler):
    def get(self):
        try:
            text = self.get_argument("text")
        except:
            text = ""
        lista = Contacts.objects(email__icontains=text)
        self.render("search.html", lista=lista, text = text)

class DeleteHandler(tornado.web.RequestHandler):
    def get(self, idcontact):
        if Contacts.objects(email=idcontact).count() == 1:
            Contacts.objects(email=idcontact).first().delete()
            self.render("message.html", title="Delete contact", message="The contact has been deleted succesfully", text="")
        else:
            self.render("message.html", title="Delete contact", message="The contact don't exists.", text="")

class UpdateHandler(tornado.web.RequestHandler):
    def get(self, idcontact):
        if Contacts.objects(email=idcontact).count() == 1:
            contact = Contacts.objects(email=idcontact).first()
            self.render("update.html", lastname=contact.lastname, firstname=contact.firstname, phone=contact.phone, email=contact.email, text="")
        else:
            self.render("message.html", title="Update contact", message="The contact don't exists.", text="")

class UpdateDataHandler(tornado.web.RequestHandler):
    def post(self):
        try:
            idcontact = self.get_argument("email")
            if Contacts.objects(email=idcontact).count() == 1:
                contact = Contacts.objects(email=idcontact).first()
                contact.lastname = self.get_argument("lastname")
                contact.firstname = self.get_argument("firstname")
                contact.phone = self.get_argument("phone")
                contact.save()
                self.render("message.html", title="Update contact", message="The contact has been updated succesfully", text="")
            else:
                self.render("message.html", title="Update contact", message="The contact don't exists.", text="")
        except:
            self.render("message.html", title="Update contact", message="Uno o mas campos son necesarios para el registro.", text="")

settings = {
    "static_path": "static",
    "template_path": "templates"
}

application = tornado.web.Application([
    (r"/", MainHandler),
    (r"/register", RegisterHandler),
    (r"/search", SearchHandler),
    (r"/delete/([a-zA-Z0-9\/\-\._]+[@][a-zA-Z0-9\/\-\._]+[.][a-zA-Z0-9]+)", DeleteHandler),
    (r"/update/([a-zA-Z0-9\/\-\._]+[@][a-zA-Z0-9\/\-\._]+[.][a-zA-Z0-9]+)", UpdateHandler),
    (r"/update", UpdateDataHandler),
], **settings)

if __name__ == "__main__":
    http_server = tornado.httpserver.HTTPServer(application)
    http_server.listen(8888)
    tornado.ioloop.IOLoop.instance().start()
