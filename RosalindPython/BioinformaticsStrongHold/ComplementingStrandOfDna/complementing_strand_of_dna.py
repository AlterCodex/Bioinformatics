"""
n DNA strings, symbols 'A' and 'T' are complements of each other, as are 'C' and 'G'.

The reverse complement of a DNA string s is the string sc formed by reversing the symbols of s, then taking the complement of each symbol (e.g., the reverse complement of "GTCA" is "TGAC").

Given: A DNA string s of length at most 1000 bp.

Return: The reverse complement sc of s.
"""
from BioinformaticsStrongHold.utils.simple_adn_reader import SimpleAdnReader
from BioinformaticsStrongHold.utils.validatios import isNucloid


def complementing_strand_of_dna(dnaString):
    transform = {
        'A': 'T',
        'C': 'G',
        'G': 'C',
        'T': 'A'
    }
    result = []
    for char in dnaString:
        if isNucloid(char):
            result.append(transform[char])
    result.reverse()
    return ''.join(result)


def test_base():
    reader = SimpleAdnReader('test.input')
    input = reader.read()
    expected_output = 'ACCGGGTTTT'
    output = complementing_strand_of_dna(input)
    assert expected_output == output


def test_case():
    reader = SimpleAdnReader('rosalind_revc.txt')
    input = reader.read()
    output = complementing_strand_of_dna(input)
    print(output)