---
title: "&lt;ostream&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: d6e56cc0-c8df-4dbe-be10-98e14c35ed3a
caps.latest.revision: 15
---
# &lt;ostream&gt; functions
||||  
|-|-|-|  
|[swap](#swap)|[endl](#endl)|[ends](#ends)|  
|[flush](#flush)|  
  
##  \<a name="endl">\</a>  endl  
 Terminates a line and flushes the buffer.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The element type.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Character traits.  
  
### Return Value  
 An object of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
### Remarks  
 The manipulator calls <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>**.**[put](../vs140/basic_ostream-class.md#basic_ostream__put)( <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>**.** [widen](../vs140/basic_ios-class.md#basic_ios__widen)( **'\n'**)), and then calls <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>**.**[flush](../vs140/basic_ostream-class.md#basic_ostream__flush). It returns <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **testing**    
##  \<a name="ends">\</a>  ends  
 Terminates a string.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The element type.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Character traits.  
  
### Return Value  
 An object of type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
### Remarks  
 The manipulator calls <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>**.**[put](../vs140/basic_ostream-class.md#basic_ostream__put)( <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>( **'\0'**)). It returns <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **ab c**    
##  \<a name="flush">\</a>  flush  
 Flushes the buffer.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The element type.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Character traits.  
  
### Return Value  
 An object of type <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
### Remarks  
 The manipulator calls <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>**.**[flush](../vs140/basic_ostream-class.md#basic_ostream__flush). It returns <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **testing**    
##  \<a name="swap">\</a>  swap  
 Exchanges the values of two <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 An lvalue reference to a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 An lvalue reference to a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The template function <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> executes <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
## See Also  
 [&lt;ostream&gt;](../vs140/-ostream-.md)