---
title: "DISP_PROPERTY_EX"
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
  - "AFXDISP/DISP_PROPERTY_EX"
  - "DISP_PROPERTY_EX"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DISP_PROPERTY_EX macro"
ms.assetid: 7c4749f7-8562-42c4-a8ad-286299bfa4b7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DISP_PROPERTY_EX
Defines an OLE automation property and name the functions used to get and set the property's value in a dispatch map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Name of the class.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 External name of the property.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Name of the member function used to get the property.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Name of the member function used to set the property.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A value specifying the property's type.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> functions have signatures determined by the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> argument. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function takes no arguments and returns a value of the type specified by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function takes an argument of the type specified by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and returns nothing.  
  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> argument is of type **VARTYPE**. Possible values for this argument are taken from the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> enumeration. For a list of these values, see the Remarks for the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter in [DISP_FUNCTION](../vs140/disp_function.md). Note that <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, listed in the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> remarks, is not permitted as a property data type.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [Dispatch Maps](../vs140/dispatch-maps.md)   
 [DECLARE_DISPATCH_MAP](../vs140/declare_dispatch_map.md)   
 [DISP_PROPERTY](../vs140/disp_property.md)   
 [DISP_FUNCTION](../vs140/disp_function.md)   
 [BEGIN_DISPATCH_MAP](../vs140/begin_dispatch_map.md)   
 [END_DISPATCH_MAP](../vs140/end_dispatch_map.md)