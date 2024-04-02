import unittest
import mathematics

class TestMathMethods(unittest.TestCase):

    def test_add(self):
        self.assertEqual(3, mathematics.add(1, 2))
        self.assertEqual(10, mathematics.add(3, 7))

    def test_multiply(self):
        self.assertEqual(50, mathematics.multiply(5, 10))

    def test_power(self):
        self.assertEqual(256, mathematics.power(2, 8))

if __name__ == '__main__':
    unittest.main()