## DesignerPDFViewer

### Problem

When a contiguous block of text is selected in a **PDF viewer**, the selection is highlighed with a blue rectangle. In this PDF viewer, each word is highlighted independently. For instance : 

![Image of Yaktocat](https://s3.amazonaws.com/hr-challenge-images/22869/1471640108-6c01750b16-PDF-highighting.png)

There is a array of **26** character heights aligned by index to their letters. For example, 'a' is at index **0** and 'z' is at index **25**. There wil also be a string. Using the letter heights given, determine the area of the rectangle highlight in **mm²**
assuming all letters are **1mm** wide.

*EXAMPLE*

<font size="4"> h = [1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7] </font>

word = "torn"

The heights are **t = 2, o = 1 , r = 1 and n = 1.** The tallest letter is 2 high and there are 4 letters. 

The highlighted area will be **2x4 = 8 mm²**


