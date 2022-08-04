from BioinformaticsStrongHold.utils.simple_adn_reader import SimpleAdnReader
'''An RNA string is a string formed from the alphabet containing 'A', 'C', 'G', and 'U'.

Given a DNA string t corresponding to a coding strand, its transcribed RNA string u is formed by replacing all occurrences of 'T' in t with 'U' in u.

Given: A DNA string t having length at most 1000 nt.

Return: The transcribed RNA string of t.'''

def transform(input):
     return input.replace('T','U')


def test_base_case():
    reader = SimpleAdnReader('test.input')
    input = reader.read()
    expected_output = "GAUGGAACUUGACUACGUAAAUU"
    output = transform(input)
    assert expected_output == output


def test_case():
    reader = SimpleAdnReader('rosalind_rna.txt')
    input = reader.read()
    output = transform(input)
    print(output)