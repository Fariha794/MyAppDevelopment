void transPosition(string b)
{
    int key[7] = {4,3,1,2,5,6,7};
    //gives d the size of the key
    int d = sizeof(key) / sizeof(key[0]);

    char matrix[4][7];
    //this loop will put the string in a 2x2 char array
    for(unsigned int i = 0; i < b.length(); i++)
    {
        matrix[i/d][i%d] = b[i];
    }

//just to check, we use this loop
//to see if the array has the letters
//in order from the string
    for(int i = 0; i < 4; i++)
    {
        for(int j = 0; j < 7; j++)
        {
            cout << matrix[i][j];
        }
        cout << endl;
    }
}