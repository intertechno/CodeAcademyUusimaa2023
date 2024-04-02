import mathematics
import unittest

# code from Chat GPT
class TestMathFunctions(unittest.TestCase):

    def test_add(self):
        self.assertEqual(mathematics.add(2, 3), 5)
        self.assertEqual(mathematics.add(-1, 5), 4)
        self.assertEqual(mathematics.add(0, 0), 0)

    def test_multiply(self):
        self.assertEqual(mathematics.multiply(2, 3), 6)
        self.assertEqual(mathematics.multiply(-1, 5), -5)
        self.assertEqual(mathematics.multiply(0, 100), 0)

    def test_power(self):
        self.assertEqual(mathematics.power(2, 3), 8)
        self.assertEqual(mathematics.power(5, 0), 1)
        self.assertEqual(mathematics.power(0, 5), 0)
        self.assertEqual(mathematics.power(4, 1), 4)

if __name__ == '__main__':
    unittest.main()
