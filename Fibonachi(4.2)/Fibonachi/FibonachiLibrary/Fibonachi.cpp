#include "Fibonachi.h"

int ValueOfIndex(int index){
    if (index == 1 || index == 2) return (index - 1); 
    return ValueOfIndex(index - 1) + ValueOfIndex(index - 2); 
}

int Find(int value){
    int index = 2, temp1 = 0, temp2 = 1, number = 0;
    if(value == 0){
        return 1;
    }
    else if(value == 1){
        return 2;
    }
    else{
        while(value >= number){
            if (value == number){
                return index;
            }
            number = temp1 + temp2;
            index++;
        }
    }
    return -1;

}

int SumOfNumbers(int index){  
    int sum;
    for(int i = 1; i <= index; i++){
        sum += ValueOfIndex(i);
    }
    return sum;
}
