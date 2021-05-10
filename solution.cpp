// Solution in c++
#include <iostream>

int AddUpTo(int n) {
    return n * (n + 1) / 2;
}

int main()
{
    try 
    {
        int n;
        std::cout << "Input A Positive Number: ";
        std::cin >> n;
        if (!std::cin) {
            std::cout << "Invalid Input!" << std::endl;
        }
        else if (n <= 0) {
            std::cout << "Not A Positive Integer!" << std::endl;
        }
        else {
            std::cout << "Sum of " << n << ": " << AddUpTo(n) << std::endl;
        }
    }
    catch (std::exception e) 
    {
        std::cout << e.what() << std::endl;
    }

}
