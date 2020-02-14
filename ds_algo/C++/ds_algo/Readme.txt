To copy algoexpert solution from their website:
    1.  Select the code part using mouse/shift selection. i.e Select al the lines that you want to copy
    2.  Press Ctrl + A
    3.  Right click and select copy option (Ctrl + C will not work)
    4.  We will get extra stuff copied as well due to Ctrl + A, we will have to delete it, along with the first line of comment containing algoexpert copyright statement
    5.  We will get errors because hearders might be missing, we will have to include them by ourselves

Errors:
    1.  If there are swiggly line under using namespace std;
        It is because the first line of the .cpp file would have be a comment line. 
        The preprocessors should be the first few lines in the .cpp file, so remove the comments, 
        i.e // Copyright © 2020 AlgoExpert, LLC. All rights reserved.