---
title: "collate Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std::collate"
  - "locale/std::collate"
  - "std.collate"
  - "collate"
  - "Collate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "collate class"
ms.assetid: 92168798-9628-4a2e-be6e-fa62dcd4d6a6
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# collate Class
A template class that describes an object that can serve as a locale facet to control the ordering and grouping of characters within a string, comparisons between them and the hashing of strings.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The type used within a program to encode characters.  
  
## Remarks  
 As with any locale facet, the static object ID has an initial stored value of zero. The first attempt to access its stored value stores a unique positive value in  **id.** In some languages, characters are grouped and treated as a single character, and in others, individual characters are treated as if they were two characters. The collating services provided by the collate class provide the way to sort these cases.  
  
### Constructors  
  
|||  
|-|-|  
|[collate](#collate__collate)|The constructor for objects of class <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> that serves as a locale facet to handle string sorting conventions.|  
  
### Typedefs  
  
|||  
|-|-|  
|[char_type](#collate__char_type)|A type that describes a character of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.|  
|[string_type](#collate__string_type)|A type that describes a string of type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> containing characters of type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[compare](#collate__compare)|Compares two character sequences according to their facet-specific rules for equality or inequality.|  
|[do_compare](#collate__do_compare)|A virtual function called to compare two character sequences according to their facet-specific rules for equality or inequality.|  
|[do_hash](#collate__do_hash)|A virtual function called to determine the hash value of sequences according to their facet-specific rules.|  
|[do_transform](#collate__do_transform)|A virtual function called to convert a character sequence from a locale to a string that may be used in lexicographical comparisons with other character sequences similarly converted from the same locale.|  
|[hash](#collate__hash)|Determines the hash value of sequence according to their facet-specific rules.|  
|[transform](#collate__transform)|Converts a character sequence from a locale to a string that may be used in lexicographical comparisons with other character sequences similarly converted from the same locale.|  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
##  \<a name="collate__char_type">\</a>  collate::char_type  
 A type that describes a character of type **CharType**.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **CharType**.  
  
##  \<a name="collate__collate">\</a>  collate::collate  
 The constructor for objects of class collate that serves as a locale facet to handle string sorting conventions.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Integer value used to specify the type of memory management for the object.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The name of the locale.  
  
### Remarks  
 The possible values for the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> parameter and their significance are:  
  
-   0: The lifetime of the object is managed by the locales that contain it.  
  
-   1: The lifetime of the object must be manually managed.  
  
-   \> 0: These values are not defined.  
  
 The constructor initializes its base object with **locale::**[facet](../vs140/locale-class.md#facet_class)( <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>).  
  
##  \<a name="collate__compare">\</a>  collate::compare  
 Compares two character sequences according to their facet-specific rules for equality or inequality.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Pointer to the first element in the first sequence to be compared.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Pointer to the last element in the first sequence to be compared.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Pointer to the first element in the second sequence to be compared.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Pointer to the last element in the second sequence to be compared.  
  
### Return Value  
 The member function returns:  
  
-   –1 if the first sequence compares less than the second sequence.  
  
-   +1 if the second sequence compares less than the first sequence.  
  
-   0 if the sequences are equivalent.  
  
### Remarks  
 The first sequence compares less if it has the smaller element in the earliest unequal pair in the sequences, or, if no unequal pairs exist, but the first sequence is shorter.  
  
 The member function returns [do_compare](#collate__do_compare)( <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="collate__do_compare">\</a>  collate::do_compare  
 A virtual function called to compare two character sequences according to their facet-specific rules for equality or inequality.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Pointer to the first element in the first sequence to be compared.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Pointer to the last element in the first sequence to be compared.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Pointer to the first element in the second sequence to be compared.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Pointer to the last element in the second sequence to be compared.  
  
### Return Value  
 The member function returns:  
  
-   -1 if the first sequence compares less than the second sequence.  
  
-   +1 if the second sequence compares less than the first sequence.  
  
-   0 if the sequences are equivalent.  
  
### Remarks  
 The protected virtual member function compares the sequence at [                        *_First1, Last1)* with the sequence at                         *[_First2, _Last2*). It compares values by applying **operator<** between pairs of corresponding elements of type **CharType**. The first sequence compares less if it has the smaller element in the earliest unequal pair in the sequences or if no unequal pairs exist but the first sequence is shorter.  
  
### Example  
  See the example for [collate::compare](#collate__compare), which calls <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
##  \<a name="collate__do_hash">\</a>  collate::do_hash  
 A virtual function called to determine the hash value of sequences according to their facet-specific rules.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 A pointer to the first character in the sequence whose has value is to be determined.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A pointer to the last character in the sequence whose has value is to be determined.  
  
### Return Value  
 A hash value of type **long** for the sequence.  
  
### Remarks  
 A hash value can be useful, for example, in distributing sequences pseudo-randomly across an array of lists.  
  
### Example  
  See the example for [hash](#collate__hash), which calls <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
##  \<a name="collate__do_transform">\</a>  collate::do_transform  
 A virtual function called to convert a character sequence from a locale to a string that may be used in lexicographical comparisons with other character sequences similarly converted from the same locale.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 A pointer to the first character in the sequence to be converted.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 A pointer to the last character in the sequence to be converted.  
  
### Return Value  
 A string that is the transformed character sequence.  
  
### Remarks  
 The protected virtual member function returns an object of class [string_type](#collate__string_type) whose controlled sequence is a copy of the sequence [ <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>). If a class derived from collate\< **CharType**> overrides [do_compare](#collate__do_compare), it should also override <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> to match. When passed to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, two transformed strings should yield the same result that you would get from passing the untransformed strings to compare in the derived class.  
  
### Example  
  See the example for [transform](#collate__transform), which calls <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
##  \<a name="collate__hash">\</a>  collate::hash  
 Determines the hash value of sequence according to their facet-specific rules.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A pointer to the first character in the sequence whose has value is to be determined.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 A pointer to the last character in the sequence whose has value is to be determined.  
  
### Return Value  
 A hash value of type **long** for the sequence.  
  
### Remarks  
 The member function returns [do_hash](#collate__do_hash)( <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>).  
  
 A hash value can be useful, for example, in distributing sequences pseudo-randomly across an array of lists.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **541187293 551279837**    
##  \<a name="collate__string_type">\</a>  collate::string_type  
 A type that describes a string of type <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> containing characters of type **CharType**.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 The type describes a specialization of template class [basic_string](../vs140/basic_string-class.md) whose objects can store copies of the source sequence.  
  
### Example  
  For an example of how to declare and use <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, see [transform](#collate__transform).  
  
##  \<a name="collate__transform">\</a>  collate::transform  
 Converts a character sequence from a locale to a string that may be used in lexicographical comparisons with other character sequences similarly converted from the same locale.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 A pointer to the first character in the sequence to be converted.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 A pointer to the last character in the sequence to be converted.  
  
### Return Value  
 A string that contains the transformed character sequence.  
  
### Remarks  
 The member function returns [do_transform](#collate__do_transform)( <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  **????????    ?**  
**????**  
**???????      ?**  
**????**  
**-1-11**    
## See Also  
 [\<locale>](../vs140/-locale-.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)