---
title: "_com_error::_com_error"
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
  - "_com_error._com_error"
  - "_com_error::_com_error"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_com_error method"
ms.assetid: 0a69e46c-caab-49ef-b091-eee401253ce6
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _com_error::_com_error
**Microsoft Specific**  
  
 Constructs a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> information.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 **IErrorInfo** object.  
  
 **bool fAddRef=false**  
 Causes the constructor to call AddRef on a non-null **IErrorInfo** interface. This provides for correct reference counting in the common case where ownership of the interface is passed into the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object, such as:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If you do not want your code to transfer ownership to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object, and the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is required to offset the **Release** in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> destructor, construct the object as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.  
  
## Remarks  
 The first constructor creates a new object given an <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and optional **IErrorInfo** object. The second creates a copy of an existing <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_com_error Class](../vs140/_com_error-class.md)