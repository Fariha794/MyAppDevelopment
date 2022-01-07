#include <iostream>
using namespace std;

int main()
{
    char TextCheck[26] = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
    char KeyCheck[26] = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

    string text, key;

    cout << "\nEnter Text to Encrypt: ";
    cin >> text;
    cout << "\nEnter Key: ";
    cin >> key;

    //Converting User given text to uppercase.
    for (int i = 0; i < text.length(); i++)
    {
        text[i] = toupper(text[i]);
    }
    //Converting User given key to uppercase.
    for (int i = 0; i < key.length(); i++)
    {
        key[i] = toupper(key[i]);
    }

    //This array will map user given key to the user given text.
    char NewKey[text.length()];

    int j = 0;
    for (int i = 0; i < text.length(); i++)
    {
        if (j == key.length())
        {
            j = 0;
        }
        NewKey[i] = key[j++];
    }

    //Encryption process started.
    for (int i = 0; i < text.length(); i++)
    {
        int textNo, keyNo, encryptedPosition;

        for (int k = 0; k < 26; k++)
        {
            if (TextCheck[k] == text[i])
            {
                textNo = k;
                break;
            }
        }

        for (int k = 0; k < 26; k++)
        {
            if (KeyCheck[k] == NewKey[i])
            {
                keyNo = k;
                break;
            }
        }

        encryptedPosition = (textNo + keyNo) % 26;

        text[i] = TextCheck[encryptedPosition];
    }

    cout << "\n\nEncrypted Text: ";
    for (int i = 0; i < text.length(); i++)
    {
        cout << text[i];
    }

    //Decryption process started.
    for (int i = 0; i < text.length(); i++)
    {
        int textNo, keyNo, decryptedPosition;

        for (int k = 0; k < 26; k++)
        {
            if (TextCheck[k] == text[i])
            {
                textNo = k;
                break;
            }
        }

        for (int k = 0; k < 26; k++)
        {
            if (KeyCheck[k] == NewKey[i])
            {
                keyNo = k;
                break;
            }
        }

        decryptedPosition = (textNo - keyNo + 26) % 26;

        text[i] = TextCheck[decryptedPosition];
    }

    cout << "\n\nDecrypted Text: ";
    for (int i = 0; i < text.length(); i++)
    {
        cout << text[i];
    }
    cout << endl;

    return 0;
}