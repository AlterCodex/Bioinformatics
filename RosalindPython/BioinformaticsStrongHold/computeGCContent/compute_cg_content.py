from decimal import Decimal

from BioinformaticsStrongHold.utils.simple_adn_reader import SimpleAdnReader


def prepare_data(input):
    reader = SimpleAdnReader(input)
    raw_data = {}
    sequence_name = reader.read_line()
    raw_data[sequence_name] = ""
    while sequence_name is not None and sequence_name != '':
        line = reader.read_line()
        if line is None or line == '' or line[0] == '>':
            sequence_name = line
            raw_data[sequence_name] = ""
        else:
            raw_data[sequence_name] += line.strip()
    return raw_data


def test():
    raw_data = prepare_data("test.input")
    print(solve(raw_data))

def resolve():
    raw_data = prepare_data("rosalind_gc.txt")
    print(solve(raw_data))


def compute_cg_content(adn):
    if adn == "":
        return 0
    cg = Decimal(0)
    total = Decimal(0)
    for i in adn:
        if i == 'C' or i == 'G':
            cg += 1
        total += 1
    return ((cg / total) * 100).real

def solve(raw_data):
    max = Decimal(0)
    result = ""
    for key in raw_data:
        temp = compute_cg_content(raw_data[key])
        if temp > max:
            max = temp
            result = key
    return result , max


if __name__ == '__main__':
    resolve()
