"""
A string is simply an ordered collection of symbols selected from some alphabet and formed into a word; the length of a string is the number of symbols that it contains.

An example of a length 21 DNA string (whose alphabet contains the symbols 'A', 'C', 'G', and 'T') is "ATGCTTCAGAAAGGTCTTACG."

Given: A DNA string s of length at most 1000 nt.

Return: Four integers (separated by spaces) counting the respective number of times that the symbols 'A', 'C', 'G', and 'T' occur in s.
"""
from BioinformaticsStrongHold.utils.simple_adn_reader import SimpleAdnReader
from BioinformaticsStrongHold.utils.validatios import isNucloid


def count_dna_nucloides(dnaString):
    result = {
        'A': 0,
        'C': 0,
        'G': 0,
        'T': 0
    }
    for char in dnaString:
        if isNucloid(char):
            result[char] = result[char] + 1
    return [result['A'], result['C'], result['G'], result['T']]


def test_count():
    reader = SimpleAdnReader('test.input')
    input = reader.read()
    expected_output = [20, 12, 17, 21]
    output = count_dna_nucloides(input)
    assert expected_output == output


def test_case():
    reader = SimpleAdnReader('rosalind_dna.txt')
    input = reader.read()
    output = count_dna_nucloides(input)
    print(output)