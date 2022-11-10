from BioinformaticsStrongHold.utils.abstract_reader import AbstractReader


class SimpleAdnReader(AbstractReader):

    def __init__(self, file):
        self.file = file
        self.f = open(file, "r")

    def read(self):
        return self.f.read()

    def read_line(self):
        return self.f.readline()
