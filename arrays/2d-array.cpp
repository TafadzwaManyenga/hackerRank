#include <bits/stdc++.h>

using namespace std;

// Complete the hourglassSum function below.
int hourglassSum(vector<vector<int>> arr) {
    int max_sum = -1000;
    
    int sum = 0;
    
    int matrix[3][3];
    
    //iterate through the whole data set
    int start_x= 0;
    int max_x=3;
    
    int start_y=0;
    int max_y=3;
    
    int endFunction = false;
    
    while(endFunction==false){
        while (max_x<=6) {
            //select an hourglass
            for (int a = start_y; a<max_y; a++) {
                for (int b= start_x; b<max_x; b++) {
                    sum+=arr[a][b];
                }
            }
            
            
            //left exclusion
            sum-=arr[start_y+1][start_x];
            
            //right exclusion
            sum-=arr[start_y+1][max_x-1];
            
            if(sum>max_sum)max_sum=sum;
            sum=0;
            
            max_x++;
            start_x++;
        }
        max_x=3;
        start_x=0;
        max_y++;start_y++;
        
        if (max_y>6) {
            endFunction=true;
        }
    }
    
    return max_sum;
}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    vector<vector<int>> arr(6);
    for (int i = 0; i < 6; i++) {
        arr[i].resize(6);

        for (int j = 0; j < 6; j++) {
            cin >> arr[i][j];
        }

        cin.ignore(numeric_limits<streamsize>::max(), '\n');
    }

    int result = hourglassSum(arr);

    fout << result << "\n";

    fout.close();

    return 0;
}
