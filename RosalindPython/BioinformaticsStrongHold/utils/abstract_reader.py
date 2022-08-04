import abc


class AbstractReader(abc.ABC):

    @abc.abstractmethod
    def read(self):
        pass
