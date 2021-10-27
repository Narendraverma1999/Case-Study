'''Create a program that asks the user to enter their name and their age. Print out a message
addressed to them that tells them the year that they will turn 100 years old.'''

#without using function

'''name=str(input("enter your name :"))
agee=int(input("enter your current age:"))
hundredth_yr=2021+(100-agee)
print(name,"become 100 yrs old in",hundredth_yr)
'''

#using function

name=str(input("enter your name :"))
agee=int(input("enter your current age:"))
def age(n,a):
    hundredth_yr=2021+(100-a)
    return hundredth_yr
print(name,"become 100 yrs old in",age(name,agee))