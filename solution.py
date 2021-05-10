# Solution in python
def addUpTo(n):
    return n * (n + 1) / 2


try:
    n = int(input("Enter A Positive Number: "))
    if n <= 0:
        print("Not A Positive Integer!")
    else:
        print("Sum Of {N}: {sum}").format(N=n, sum=addUpTo(n))
except ValueError:
    print("Invalid Input!")
