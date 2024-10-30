# Jonathan Cales
# WidgetsIncIMS
# 12/06/2023
# Inventory Management System - Widgets Inc. will be able to edit and survey their
# companies inventory at will with this program.

try:

# It is important to note that some functions have been implemented with If statements to detect if the Items dictionary is empty or the IDs/Keys do not exist.
# These statements should prevent the user from executing commands that may cause KeyError's to avoid exceptions being raised continuously as the Runtime
# function will not run more than once if an exception is raised.
    
    # Acceptable menu inputs are put in a list and Items in a dictionary to be called back to.
    accepted_inputs = [1, 2, 3, 4, 5, 0]
    Items = {}

    # Menu Print and Prompt Function
    def menu():
    
        print("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-")
        print("|           Widgets Inc           |")
        print("|   Inventory Management System   |")
        print("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-")
        print("1.) Print Inventory")
        print("2.) Add Item to Inventory")
        print("3.) Remove Item from Inventory")
        print("4.) Change Quantity of Item")
        print("5.) Search Inventory")
        print("0.) Quit")

        x = True
        
        while x == True:
            user_input = (int(input("\nSelect Item: ")))
            print("\n")
            if user_input in accepted_inputs:
                x = user_input
                return x
            else:
                print("\nInvalid selection.")
                x == True

    # Continue Prompt Function
    def Continue():
        choice = str(input("Do you wish to continue (Y/N): "))
        print("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-")
        if choice == "n" or choice == "N":
            return 0
        else:
            print("\n")
            return 99
        
    # Print Inventory Function
    # The command will print a special statement if the inventory is empty.
    def PrintInventory():
        print("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-")
        print("Current Inventory")
        if Items == {}:
            print("\n = Add Items to your stock! = \n")
        for i in Items.keys():
            print("\nName: " + str(Items[i][0]))
            print("Quantity in stock.: " + str(Items[i][1]))
            print("Identification Number: " + str(i))
        print("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-")
    
    # Add Item Function
    # If the ID is already in use for an item, the user will have to give another.
    def AddItem():
        print("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-")
        ID = int(input("Please enter an item identifer: "))
        while ID in Items:
            print("\nThis ID already exists. Please try another.")
            ID = int(input("Please enter an item identifer: "))
        name = str(input("Enter item name: "))
        quantity = int(input("Enter quantity in stock: "))
        Items[ID] = [name, quantity]
        print("\n" + name + " was added to catalog.")

    # Remove Item Function
    # If the ID for removal cannot be found, the user is asked to give another.
    def RemoveItem():
        print("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-")
        ID = int(input("Enter the ID of the item for removal: "))
        while ID not in Items:
            print("\nThis ID doesn't exist. Please try another.")
            ID = int(input("Please enter another item identifer: "))
        print("\n" + str(Items[ID][0]) + " was removed with a quantity of " + str(Items[ID][1]) + ".")
        del Items[ID]
        

    # Change Quantity Function
    # If the inventory is empty, the command will not run.
    def ChangeQuantity():
        print("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-")
        if Items == {}:
            print("\n There is nothing to change.")
        else:    
            ID = int(input("Enter item identifer: "))
            NewQuantity = int(input("Enter quantity for " + str(Items[ID][0]) + ": "))
            Items[ID][1] = NewQuantity
            print("\n" + str(Items[ID][0]) + " now has " + str(Items[ID][1]) + " items in stock.")

    # Search Inventory Function
    # If the inventory is empty, the command will not run.
    def SearchInventory():
        print("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-")
        if Items == {}:
            print("There is nothing to search.")
        else:
            ItemToSearch = int(input("Enter item identifer: "))
            print("\n" + str(Items[ItemToSearch][0]) + " has " + str(Items[ItemToSearch][1]) + " items in stock.")

    # The Runtime Function is to act as a loop, always permitting the user to be in control until they give it up.
    # This will be used when exceptions are raised as well to keep the program flowing seemlessly.
    def Runtime():
        # Selection variable will keep track of user choices from the menu screen.
        selection = 99
        while selection != 0:
            selection = menu()
            if selection == 1:
                PrintInventory()
                selection = Continue()
            if selection == 2:
                AddItem()
                selection = Continue()
            if selection == 3:
                RemoveItem()
                selection = Continue()
            if selection == 4:
                ChangeQuantity()
                selection = Continue()
            if selection == 5:
                SearchInventory()
                selection = Continue()
        
    # Creating objects to store in the inventory.
    Items[1] = ["Small Widget", 10]
    Items[2] = ["Medium Widget", 20]
    Items[3] = ["Large Widget", 5]

    # Program is initiated when the initial inventory is made and all functions are defined and ready for use.
    Runtime()

# All exceptions will define themselves and return control to the user.
# Not fool-proof. If exceptions are raised a second time, the error will end the program.
except ValueError:
    print("\n You can only enter numbers. Please try again.\n")
    Runtime()
    
except TypeError:
    print("\n Please ensure your inputs can be interpreted properly as numbers or letters when appropriate. Please try again.")
    Runtime()

except KeyError:
    print("\n Item was not found or the input could not be used properly. Please try again.\n")
    Runtime()
    


