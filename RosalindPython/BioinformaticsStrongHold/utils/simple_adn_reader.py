from BioinformaticsStrongHold.utils.abstract_reader import AbstractReader


class SimpleAdnReader(AbstractReader):

    def __init__(self, file):
        self.file = file

    def read(self):
        f = open(self.file, "r")
        return f.read()
