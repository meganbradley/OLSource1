---
title: "fpos Class"
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
  - "std.fpos"
  - "std::fpos"
  - "iosfwd/std::fpos"
  - "fpos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "fpos class, about fpos class"
  - "fpos class"
ms.assetid: ffd0827c-fa34-47f4-b10e-5cb707fcde47
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fpos Class
The template class describes an object that can store all the information needed to restore an arbitrary file-position indicator within any stream. An object of class fpos\< **St**> effectively stores at least two member objects:  
  
-   A byte offset, of type [streamoff](../vs140/-ios--typedefs.md#streamoff).  
  
-   A conversion state, for use by an object of class basic_filebuf, of type **St**, typically <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 It can also store an arbitrary file position, for use by an object of class [basic_filebuf](../vs140/basic_filebuf-class.md), of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. For an environment with limited file size, however, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> may sometimes be used interchangeably. For an environment with no streams that have a state-dependent encoding, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> may actually be unused. Therefore, the number of member objects stored may vary.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *Statetype*  
 State information.  
  
### Constructors  
  
|||  
|-|-|  
|[fpos](#fpos__fpos)|Create an object that contains information about a position (offset) in a stream.|  
  
### Member Functions  
  
|||  
|-|-|  
|[seekpos](#fpos__seekpos)|Used internally by the Standard C++ Library only. Do not call this method from your code.|  
|[state](#fpos__state)|Sets or returns the conversion state.|  
  
### Operators  
  
|||  
|-|-|  
|[operator!=](#fpos__operator_neq)|Tests file-position indicators for inequality.|  
|[operator+](#fpos__operator_add)|Increments a file-position indicator.|  
|[operator+=](#fpos__operator_add_eq)|Increments a file-position indicator.|  
|[operator-](#fpos__operator-)|Decrements a file-position indicator.|  
|[operator-=](#fpos__operator-_eq)|Decrements a file-position indicator.|  
|[operator==](#fpos__operator_eq_eq)|Tests file-position indicators for equality.|  
|[operator streamoff](#fpos__operator_streamoff)|Casts object of type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to object of type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
##  \<a name="fpos__fpos">\</a>  fpos::fpos  
 Create an object that contains information about a position (offset) in a stream.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The offset into the stream.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The starting state of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.  
  
 *_Filepos*  
 The offset into the stream.  
  
### Remarks  
 The first constructor stores the offset <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, relative to the beginning of file and in the initial conversion state (if that matters). If <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is -1, the resulting object represents an invalid stream position.  
  
 The second constructor stores a zero offset and the object <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
##  \<a name="fpos__operator_neq">\</a>  fpos::operator!=  
 Tests file-position indicators for inequality.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The file-position indicator against which to compare.  
  
### Return Value  
 **true** if the file-position indicators are not equal, otherwise **false**.  
  
### Remarks  
 The member function returns **!**( **\*this ==** <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>).  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="fpos__operator_add">\</a>  fpos::operator+  
 Increments a file-position indicator.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The offset by which you want to increment the file-position indicator.  
  
### Return Value  
 The position in the file.  
  
### Remarks  
 The member function returns **fpos(\*this) +=** <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
### Example  
  See [operator!=](#fpos__operator_neq) for a sample of using <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
##  \<a name="fpos__operator_add_eq">\</a>  fpos::operator+=  
 Increments a file-position indicator.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The offset by which you want to increment the file-position indicator.  
  
### Return Value  
 The position in the file.  
  
### Remarks  
 The member function adds <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to the stored offset member object and then returns **\*this**. For positioning within a file, the result is generally valid only for binary streams that do not have a state-dependent encoding.  
  
### Example  
  See [operator!=](#fpos__operator_neq) for a sample of using <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
##  \<a name="fpos__operator-">\</a>  fpos::operator-  
 Decrements a file-position indicator.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 File position.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Stream offset.  
  
### Return Value  
 The first member function returns **(streamoff)\*this - (streamoff)**<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. The second member function returns  **fpos(\*this) -=** <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
### Example  
  See [operator!=](#fpos__operator_neq) for a sample of using <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
##  \<a name="fpos__operator-_eq">\</a>  fpos::operator-=  
 Decrements a file-position indicator.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Stream offset.  
  
### Return Value  
 The member function returns **fpos(\*this) -=** <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
### Remarks  
 For positioning within a file, the result is generally valid only for binary streams that do not have a state-dependent encoding.  
  
### Example  
  See [operator!=](#fpos__operator_neq) for a sample of using <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
##  \<a name="fpos__operator_eq_eq">\</a>  fpos::operator==  
 Tests file-position indicators for equality.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The file-position indicator against which to compare.  
  
### Return Value  
 **true** if the file-position indicators are equal; otherwise **false**.  
  
### Remarks  
 The member function returns **(streamoff)\*this == (streamoff)**<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
### Example  
  See [operator!=](#fpos__operator_neq) for a sample of using <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
##  \<a name="fpos__operator_streamoff">\</a>  fpos::operator streamoff  
 Cast object of type <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> to object of type <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the stored offset member object and any additional offset stored as part of the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> member object.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  **0**    
##  \<a name="fpos__seekpos">\</a>  fpos::seekpos  
 This method is used internally by the Standard C++ Library only. Do not call this method from your code.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="fpos__state">\</a>  fpos::state  
 Sets or returns the conversion state.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The new conversion state.  
  
### Return Value  
 The conversion state.  
  
### Remarks  
 The first member function returns the value stored in the **St** member object. The second member function stores <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> in the **St** member object.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)