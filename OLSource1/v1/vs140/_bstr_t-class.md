---
title: "_bstr_t Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "_bstr_t"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BSTR object"
  - "_bstr_t class"
  - "BSTR object, COM encapsulation"
ms.assetid: 58841fef-fe21-4a84-aab9-780262b5201f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _bstr_t Class
**Microsoft Specific**  
  
 A <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object encapsulates the [BSTR data type](assetId:///1b2d7d2c-47af-4389-a6b6-b01b7e915228). The class manages resource allocation and deallocation through function calls to **SysAllocString** and **SysFreeString** and other <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> APIs when appropriate. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class uses reference counting to avoid excessive overhead.  
  
### Construction  
  
|||  
|-|-|  
|[_bstr_t](../vs140/_bstr_t--_bstr_t.md)|Constructs a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.|  
  
### Operations  
  
|||  
|-|-|  
|[Assign](../vs140/_bstr_t--assign.md)|Copies a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> into the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> wrapped by a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|[Attach](../vs140/_bstr_t--attach.md)|Links a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> wrapper to a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
|[copy](../vs140/_bstr_t--copy.md)|Constructs a copy of the encapsulated <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
|[Detach](../vs140/_bstr_t--detach.md)|Returns the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> wrapped by a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and detaches the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> from the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
|[GetAddress](../vs140/_bstr_t--getaddress.md)|Points to the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> wrapped by a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.|  
|[GetBSTR](../vs140/_bstr_t--getbstr.md)|Points to the beginning of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> wrapped by the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.|  
|[length](../vs140/_bstr_t--length.md)|Returns the number of characters in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.|  
  
### Operators  
  
|||  
|-|-|  
|[operator =](../vs140/_bstr_t--operator-=.md)|Assigns a new value to an existing <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.|  
|[operator +=](../vs140/_bstr_t--operator--=---.md)|Appends characters to the end of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.|  
|[operator +](../vs140/_bstr_t--operator--=---.md)|Concatenates two strings.|  
|[operator !](../vs140/_bstr_t--operator-!.md)|Checks if the encapsulated <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is a **NULL** string.|  
|[operator ==, !=, \<, >, \<=, >=](../vs140/_bstr_t-relational-operators.md)|Compares two <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> objects.|  
|[operator wchar_t* &#124; char\*](../vs140/_bstr_t--wchar_t---_bstr_t--char-.md)|Extract the pointers to the encapsulated Unicode or multibyte <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.|  
  
## END Microsoft Specific  
  
## Requirements  
 **Header:** comutil.h  
  
 **Lib:** comsuppw.lib or comsuppwd.lib (see [/Zc:wchar_t (wchar_t Is Native Type)](../vs140/-zc-wchar_t--wchar_t-is-native-type-.md) for more information)  
  
## See Also  
 [Compiler COM Support Classes](../vs140/compiler-com-support-classes.md)