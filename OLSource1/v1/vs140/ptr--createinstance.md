---
title: "ptr::CreateInstance"
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
  - "ptr.CreateInstance"
  - "msclr::com::ptr::CreateInstance"
  - "msclr.com.ptr.CreateInstance"
  - "ptr::CreateInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ptr::CreateInstance"
ms.assetid: 9e8e4c4c-1651-4839-8829-5857d74470fe
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ptr::CreateInstance
Creates an instance of a COM object within a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to the aggregate object's IUnknown interface (the controlling IUnknown). If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is not specified, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is used.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Context in which the code that manages the newly created object will run. The values are taken from the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> enumeration. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is not specified, the value CLSCTX_ALL is used.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> associated with the data and code that will be used to create the object.  
  
## Exceptions  
 If the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> already owns a reference to a COM object, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> throws \<xref:System.InvalidOperationException*>.  
  
 This function calls <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and uses \<xref:System.Runtime.InteropServices.Marshal.ThrowExceptionForHR*> to convert any error <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to an appropriate exception.  
  
## Remarks  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> uses <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to create a new instance of the specified object, identified either from a ProgID or a CLSID. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> references the newly created object and will automatically release all owned references upon destruction.  
  
## Example  
 This example implements a CLR class that uses a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to wrap its private member <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object. The class constructors use two different forms of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to create the document object either from a ProgID or from a CLSID plus a CLSCTX.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header file** \<msclr\com\ptr.h>  
  
 **Namespace** msclr::com  
  
## See Also  
 [ptr Members](../vs140/ptr-members.md)