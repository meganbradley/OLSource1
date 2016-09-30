---
title: "_U_RECT Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL::_U_RECT"
  - "_U_RECT"
  - "ATL._U_RECT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "U_RECT class"
  - "_U_RECT class"
ms.assetid: 5f880a2d-09cf-4327-bf32-a3519c4dcd63
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _U_RECT Class
This argument adapter class allows either <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> pointers or references to be passed to a function that is implemented in terms of pointers.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[_U_RECT::_U_RECT](../vs140/_u_rect--_u_rect.md)|The constructor.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[_U_RECT::m_lpRect](../vs140/_u_rect--m_lprect.md)|Pointer to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
  
## Remarks  
 The class defines two constructor overloads: one accepts a **RECT&** argument and the other accepts an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> argument. The first constructor stores the address of the reference argument in the class's single data member, [m_lpRect](../vs140/_u_rect--m_lprect.md). The argument to the pointer constructor is stored directly without conversion.  
  
## Requirements  
 **Header:** atlwin.h  
  
##  \<a name="_u_rect__m_lprect">\</a>  _U_RECT::m_lpRect  
 The class holds the value passed to either of its constructors as a public <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> data member.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="_u_rect___u_rect">\</a>  _U_RECT::_U_RECT  
 The address of the reference argument is stored in the class's single data member, [m_lpRect](../vs140/_u_rect--m_lprect.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> reference.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> pointer.  
  
### Remarks  
 The argument to the pointer constructor is stored directly without conversion.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)