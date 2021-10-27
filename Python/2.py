'''Write the above solution in a function which takes take numbers and return the bigger number
[topic covered: function]'''


num1 = float(input("Enter first number: "))
num2 = float(input("Enter second number: "))
num3 = float(input("Enter third number: "))
def largest(n1,n2,n3):
    if (n1 >= n2 and n1 >= n3):
        return n1
    elif (n2 >= n1) and (n2 >= n3):
        return n2
    else:
        return n3
print(largest(num1,num2,num3))
