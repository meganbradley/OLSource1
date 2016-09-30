---
title: "&lt;fstream&gt; typedefs"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 8dddef2d-7f17-42a6-ba08-6f6f20597d23
caps.latest.revision: 13
---
# &lt;fstream&gt; typedefs
||||  
|-|-|-|  
|[filebuf](#filebuf)|[fstream](#fstream)|[ifstream](#ifstream)|  
|[ofstream](#ofstream)|[wfilebuf](#wfilebuf)|[wfstream](#wfstream)|  
|[wifstream](#wifstream)|[wofstream](#wofstream)|  
  
##  \<a name="filebuf"></a>  filebuf  
 A type `basic_filebuf` specialized on `char` template parameters.  
  
```  
typedef basic _ filebuf<char, char _ traits<char> > filebuf;  
  
```  
  
### Remarks  
 The type is a synonym for template class [basic_filebuf](../vs140/basic_filebuf-class.md), specialized for elements of type `char` with default character traits.  
  
##  \<a name="fstream"></a>  fstream  
 A type `basic_fstream` specialized on `char` template parameters.  
  
```  
typedef basic _ fstream<char, char _ traits<char> > fstream;  
  
```  
  
### Remarks  
 The type is a synonym for template class [basic_fstream](../vs140/basic_fstream-class.md), specialized for elements of type `char` with default character traits.  
  
##  \<a name="ifstream"></a>  ifstream  
 Defines a stream to be used to read single-byte character data serially from a file. `ifstream` is a typedef that specializes the template class `basic_ifstream` for `char`.  
  
 There is also `wifstream`, a typedef that specializes `basic_ifstream` to read `wchar_t` double-wide characters. For more information, see [wifstream](../vs140/-fstream--typedefs.md#wifstream).  
  
```  
typedef basic_ifstream<char, char_traits<char> > ifstream;  
```  
  
### Remarks  
 The type is a synonym for template class `basic_ifstream`, specialized for elements of type char with default character traits. An example is  
  
 `using namespace std;`  
  
 `ifstream infile("existingtextfile.txt");`  
  
 `if (!infile.bad())`  
  
 `{`  
  
 `// Dump the contents of the file to cout.`  
  
 `cout << infile.rdbuf();`  
  
 `infile.close();`  
  
 `}`  
  
##  \<a name="ofstream"></a>  ofstream  
 A type `basic_ofstream` specialized on `char` template parameters.  
  
```  
typedef basic _ ofstream<char, char _ traits<char> > ofstream;  
  
```  
  
### Remarks  
 The type is a synonym for template class [basic_ofstream](../vs140/basic_ofstream-class.md), specialized for elements of type `char` with default character traits.  
  
##  \<a name="wfstream"></a>  wfstream  
 A type `basic_fstream` specialized on `wchar_t` template parameters.  
  
```  
typedef basic _ fstream<wchar _ t, char _ traits<wchar _ t> > wfstream;  
  
```  
  
### Remarks  
 The type is a synonym for template class [basic_fstream](../vs140/basic_fstream-class.md), specialized for elements of type `wchar_t` with default character traits.  
  
##  \<a name="wifstream"></a>  wifstream  
 A type `basic_ifstream` specialized on `wchar_t` template parameters.  
  
```  
typedef basic _ ifstream<wchar _ t, char _ traits<wchar _ t> > wifstream;  
  
```  
  
### Remarks  
 The type is a synonym for template class [basic_ifstream](../vs140/basic_ifstream-class.md), specialized for elements of type `wchar_t` with default character traits.  
  
##  \<a name="wofstream"></a>  wofstream  
 A type `basic_ofstream` specialized on `wchar_t` template parameters.  
  
```  
typedef basic _ ofstream<wchar _ t, char _ traits<wchar _ t> > wofstream;  
  
```  
  
### Remarks  
 The type is a synonym for template class [basic_ofstream](../vs140/basic_ofstream-class.md), specialized for elements of type `wchar_t` with default character traits.  
  
##  \<a name="wfilebuf"></a>  wfilebuf  
 A type `basic_filebuf` specialized on `wchar_t` template parameters.  
  
```  
typedef basic _ filebuf<wchar _ t, char _ traits<wchar _ t> > wfilebuf;  
  
```  
  
### Remarks  
 The type is a synonym for template class [basic_filebuf](../vs140/basic_filebuf-class.md), specialized for elements of type `wchar_t` with default character traits.  
  
## See Also  
 [&lt;fstream&gt;](../vs140/-fstream-.md)