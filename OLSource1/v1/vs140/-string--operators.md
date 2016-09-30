---
title: "&lt;string&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 33ce8f05-06c7-45d3-a0cb-bcd27cf93910
caps.latest.revision: 11
---
# &lt;string&gt; operators
||||  
|-|-|-|  
|[operator!=](#operator_neq)|[operator&gt;](#operator_gt_)|[operator&gt;&gt;](#operator_gt__gt_)|  
|[operator&gt;=](#operator_gt__eq)|[operator&lt;](#operator_lt_)|[operator&lt;&lt;](#operator_lt__lt_)|  
|[operator&lt;=](#operator_lt__eq)|[operator+](#operator_add)|[operator==](#operator_eq_eq)|  
  
##  \<a name="operator_add">\</a>  operator+  
 Concatenates two string objects.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A C-style string or an object of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to be concatenated.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 A C-style string or an object of type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to be concatenated.  
  
### Return Value  
 The string that is the concatenation of the input strings.  
  
### Remarks  
 The functions each overload <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to concatenate two objects of template class [basic_string](../vs140/basic_string-class.md). All effectively return <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>\< **CharType**, **Traits**, **Allocator**>(_                        *Left*). [append](../vs140/basic_string-class.md#basic_string__append)(\_                        *Right*).  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **The basic_string s1 = anti.**  
**The basic_string s2 = gravity.**  
**The C-style string s3 = heroine.**  
**The character constant c1 = !.**  
**The string concatenating s1 & s2 is: antigravity**  
**The string concatenating s1 & s3 is: antiheroine**  
**The string concatenating s1 & s3 is: antiheroine!**    
##  \<a name="operator_neq">\</a>  operator!=  
 Tests if the string object on the left side of the operator is not equal to the string object on the right side.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 A C-style string or an object of type <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to be compared.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 A C-style string or an object of type <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to be compared.  
  
### Return Value  
 **true** if the string object on the left side of the operator is not lexicographically equal to the string object on the right side; otherwise **false**.  
  
### Remarks  
 The comparison between string objects is based on a pairwise lexicographical comparison of their characters. Two strings are equal if they have the same number of characters and their respective character values are the same. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **The basic_string s1 = pluck.**  
**The basic_string s2 = strum.**  
**The C-style string s3 = pluck.**  
**The strings s1 & s2 are not equal.**  
**The strings s1 & s3 are equal.**  
**The strings s3 & s2 are not equal.**    
##  \<a name="operator_eq_eq">\</a>  operator==  
 Tests if the string object on the left side of the operator is equal to the string object on the right side.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 A C-style string or an object of type <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> to be compared.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A C-style string or an object of type <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to be compared.  
  
### Return Value  
 **true** if the string object on the left side of the operator is lexicographically equal to the string object on the right side; otherwise **false**.  
  
### Remarks  
 The comparison between string objects is based on a pairwise lexicographical comparison of their characters. Two strings are equal if they have the same number of characters and their respective character values are the same. Otherwise, they are unequal.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **The basic_string s1 = pluck.**  
**The basic_string s2 = strum.**  
**The C-style string s3 = pluck.**  
**The strings s1 & s2 are not equal.**  
**The strings s1 & s3 are equal.**  
**The strings s3 & s2 are not equal.**    
##  \<a name="operator_lt_">\</a>  operator&lt;  
 Tests if the string object on the left side of the operator is less than to the string object on the right side.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 A C-style string or an object of type <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to be compared.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A C-style string or an object of type <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to be compared.  
  
### Return Value  
 **true** if the string object on the left side of the operator is lexicographically less than the string object on the right side; otherwise **false**.  
  
### Remarks  
 A lexicographical comparison between strings compares them character by character until:  
  
-   It finds two corresponding characters unequal, and the result of their comparison is taken as the result of the comparison between the strings.  
  
-   It finds no inequalities, but one string has more characters than the other, and the shorter string is considered less than the longer string.  
  
-   It finds no inequalities and finds that the strings have the same number of characters, and so the strings are equal.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **The basic_string s1 = strict.**  
**The basic_string s2 = strum.**  
**The C-style string s3 = strict.**  
**The string s1 is less than the string s2.**  
**The string s1 is not less than the string s3.**  
**The string s3 is less than the string s2.**    
##  \<a name="operator_lt__eq">\</a>  operator&lt;=  
 Tests if the string object on the left side of the operator is less than or equal to the string object on the right side.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 A C-style string or an object of type <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> to be compared.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 A C-style string or an object of type <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to be compared.  
  
### Return Value  
 **true** if the string object on the left side of the operator is lexicographically less than or equal to the string object on the right side; otherwise **false**.  
  
### Remarks  
 A lexicographical comparison between strings compares them character by character until:  
  
-   It finds two corresponding characters unequal, and the result of their comparison is taken as the result of the comparison between the strings.  
  
-   It finds no inequalities, but one string has more characters than the other, and the shorter string is considered less than the longer string.  
  
-   It finds no inequalities and finds that the strings have the same number of characters, so the strings are equal.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **The basic_string s1 = strict.**  
**The basic_string s2 = strum.**  
**The C-style string s3 = strict.**  
**The string s1 is less than or equal to the string s2.**  
**The string s1 is less than or equal to the string s3.**  
**The string s2 is greater than the string s3.**    
##  \<a name="operator_lt__lt_">\</a>  operator&lt;&lt;  
 A template function that writes a string into the output stream.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 _Ostr  
 The output stream being written to.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The string to be entered into the output stream.  
  
### Return Value  
 Writes the value of the specified string to the output stream <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
### Remarks  
 The template function overloads **operator<<** to insert an object _                        *Str* of template class [basic_string](../vs140/basic_string-class.md) into the stream \_                        *Ostr.* The function effectively returns \_                        *Ostr*. **write**( \_                        *Str*. [c_str](../vs140/basic_string-class.md#basic_string__c_str), \_                        *Str*. [size](../vs140/basic_string-class.md#basic_string__size)).  
  
##  \<a name="operator_gt_">\</a>  operator&gt;  
 Tests if the string object on the left side of the operator is greater than to the string object on the right side.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 A C-style string or an object of type <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> to be compared.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 A C-style string or an object of type <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> to be compared.  
  
### Return Value  
 **true** if the string object on the left side of the operator is lexicographically greater than the string object on the right side; otherwise **false**.  
  
### Remarks  
 A lexicographical comparison between strings compares them character by character until:  
  
-   It finds two corresponding characters unequal, and the result of their comparison is taken as the result of the comparison between the strings.  
  
-   It finds no inequalities, but one string has more characters than the other, and the shorter string is considered less than the longer string.  
  
-   It finds no inequalities and finds that the strings have the same number of characters, and so the strings are equal.  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **The basic_string s1 = strict.**  
**The basic_string s2 = strum.**  
**The C-style string s3 = stricture.**  
**The string s1 is not greater than the string s2.**  
**The string s3 is greater than the string s1.**  
**The string s2 is greater than the string s3.**    
##  \<a name="operator_gt__eq">\</a>  operator&gt;=  
 Tests if the string object on the left side of the operator is greater than or equal to the string object on the right side.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A C-style string or an object of type <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> to be compared.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 A C-style string or an object of type <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> to be compared.  
  
### Return Value  
 **true** if the string object on the left side of the operator is lexicographically greater than or equal to the string object on the right side; otherwise **false**.  
  
### Remarks  
 A lexicographical comparison between strings compares them character by character until:  
  
-   It finds two corresponding characters unequal, and the result of their comparison is taken as the result of the comparison between the strings.  
  
-   It finds no inequalities, but one string has more characters than the other, and the shorter string is considered less than the longer string.  
  
-   It finds no inequalities and finds the strings have the same number of characters, and so the strings are equal.  
  
### Example  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  **The basic_string s1 = strict.**  
**The basic_string s2 = strum.**  
**The C-style string s3 = stricture.**  
**The string s1 is less than the string s2.**  
**The string s3 is greater than or equal to the string s1.**  
**The string s2 is greater than or equal to the string s3.**    
##  \<a name="operator_gt__gt_">\</a>  operator&gt;&gt;  
 A template function that reads a string from an input stream.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The input stream used to extract the sequence  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The string that is being extracted from the input stream.  
  
### Return Value  
 Reads the value of the specified string from <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> and returns it into <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
  
### Remarks  
 The operator skips the leading white spaces unless the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> flag is set. It reads all the following characters until the next character is a white space or the end of the file is reached.  
  
 The template function overloads **operator>>** to replace the sequence controlled by <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> with a sequence of elements extracted from the stream <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>. Extraction stops:  
  
-   At end of file.  
  
-   After the function extracts <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>. **width** elements, if that value is nonzero.  
  
 After the function extracts <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>. [max_size](../vs140/basic_string-class.md#basic_string__max_size) elements.  
  
-   After the function extracts an element                                 *ch* for which [use_facet](../vs140/basic_filebuf-class.md#basic_filebuf__open)< **ctype**\< **CharType**> >( <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>). **is**( **ctype**\< **CharType**>:: **space**,                                 *ch*) is true, in which case the character is put back.  
  
 If the function extracts no elements, it calls [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>). In any case, it calls **istr**. **width**(0) and returns \* **this**.  
  
### Example  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
## See Also  
 [&lt;string&gt;](../vs140/-string-.md)