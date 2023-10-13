class Product :
    def __init__(self, name, owner):
        self.name = name
        self.owner = owner
        self.users = []

    def add_user(self, user):
        self.users.append(user)

    def remove_user(self, user):
        self.users.remove(user)

class Lesson :
    def __init__(self, name, video_link, duration):
        self.name = name
        self.video_link = video_link
        self.duration = duration
        self.products = []

    def add_product(self, product):
        self.products.append(product)

    def remove_product(self, product):
        self.products.remove(product)

class UserLesson :
    def __init__(self, user, lesson):
        self.user = user
        self.lesson = lesson
        self.view_time = 0
        self.status = "Не просмотрено"

    def update_view_time(self, time):
        self.view_time = time

        if self.view_time >= self.lesson.duration * 0.8:
            self.status = "Просмотрено"
        else:
            self.status = "Не просмотрено"