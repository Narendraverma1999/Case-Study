'''Create a program to compare three numbers and find the bigger numbers. [topics covered:
identified, variable, types, operator, if statement]'''


n1 = float(input("Enter first number: "))
n2 = float(input("Enter second number: "))
n3 = float(input("Enter third number: "))

if (n1 >= n2 and n1 >= n3):
   bigger = n1
elif (n2 >= n1) and (n2 >= n3):
   bigger = n2
else:
    bigger = n3

print("The bigger number is", bigger)


