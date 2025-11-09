import unittest
from math_utils import factorial

class TestFactorial(unittest.TestCase):
    def test_factorial_5(self):
        self.assertEqual(factorial(5), 120)

if __name__ == '__main__':
    unittest.main()
