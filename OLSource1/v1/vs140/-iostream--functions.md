---
title: "&lt;iostream&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 30b71cbb-4a42-419f-b594-7dc2c1f065a4
caps.latest.revision: 14
robots: noindex,nofollow
---
# &lt;iostream&gt; functions
||||  
|-|-|-|  
|[cerr](#cerr)|[cin](#cin)|[clog](#clog)|  
|[cout](#cout)|[wcerr](#wcerr)|[wcin](#wcin)|  
|[wclog](#wclog)|[wcout](#wcout)|  
  
##  \<a name="cerr">\</a>  cerr  
 The object <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> controls output to a stream buffer associated with the object <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, declared in \<cstdio>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Return Value  
 An [ostream](../vs140/-ostream--typedefs.md#ostream) object.  
  
### Remarks  
 The object controls unbuffered insertions to the standard error output as a byte stream. Once the object is constructed, the expression <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>[flags](../vs140/ios_base-class.md#ios_base__flags) <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> [unitbuf](../vs140/-ios--functions.md#unitbuf) is nonzero, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cin">\</a>  cin  
 Specifies the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> global stream.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 An [istream](../vs140/-istream--typedefs.md#istream) object.  
  
### Remarks  
 The object controls extractions from the standard input as a byte stream. Once the object is constructed, the call <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>[tie](../vs140/basic_ios-class.md#basic_ios__tie) returns <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>[cout](../vs140/-iostream--functions.md#cout).  
  
### Example  
  In this example, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> sets the fail bit on the stream when it encounters non-numeric characters. The program clears the fail bit and strips the invalid character from the stream to proceed.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
   **<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>**     
##  \<a name="clog">\</a>  clog  
 Specifies the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> global stream.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 An [ostream](../vs140/-ostream--typedefs.md#ostream) object.  
  
### Remarks  
 The object controls buffered insertions to the standard error output as a byte stream.  
  
### Example  
  See [cerr](../vs140/-iostream--functions.md#cerr) for an example of using <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
##  \<a name="cout">\</a>  cout  
 Specifies the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> global stream.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 An [ostream](../vs140/-ostream--typedefs.md#ostream) object.  
  
### Remarks  
 The object controls insertions to the standard output as a byte stream.  
  
### Example  
  See [cerr](../vs140/-iostream--functions.md#cerr) for an example of using <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
##  \<a name="wcerr">\</a>  wcerr  
 Specifies the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> global stream.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A [wostream](../vs140/-ostream--typedefs.md#wostream) object.  
  
### Remarks  
 The object controls unbuffered insertions to the standard error output as a wide stream. Once the object is constructed, the expression <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>[flags](../vs140/ios_base-class.md#ios_base__flags) <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> [unitbuf](../vs140/-ios--functions.md#unitbuf) is nonzero.  
  
### Example  
  See [cerr](../vs140/-iostream--functions.md#cerr) for an example of using <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
##  \<a name="wcin">\</a>  wcin  
 Specifies the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> global stream.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A [wistream](../vs140/-istream--typedefs.md#wistream) object.  
  
### Remarks  
 The object controls extractions from the standard input as a wide stream. Once the object is constructed, the call <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>[tie](../vs140/basic_ios-class.md#basic_ios__tie) returns <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>[wcout](../vs140/-iostream--functions.md#wcout).  
  
### Example  
  See [cerr](../vs140/-iostream--functions.md#cerr) for an example of using <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
##  \<a name="wclog">\</a>  wclog  
 Specifies the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> global stream.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A [wostream](../vs140/-ostream--typedefs.md#wostream) object.  
  
### Remarks  
 The object controls buffered insertions to the standard error output as a wide stream.  
  
### Example  
  See [cerr](../vs140/-iostream--functions.md#cerr) for an example of using <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
##  \<a name="wcout">\</a>  wcout  
 Specifies the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> global stream.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 A [wostream](../vs140/-ostream--typedefs.md#wostream) object.  
  
### Remarks  
 The object controls insertions to the standard output as a wide stream.  
  
### Example  
  See [cerr](../vs140/-iostream--functions.md#cerr) for an example of using <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> instances in a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> statement must be cast to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, as shown in the following example.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 For more information, see [Basic CString Operations](../vs140/basic-cstring-operations.md).  
  
## See Also  
 [&lt;iostream&gt;](../vs140/-iostream-.md)