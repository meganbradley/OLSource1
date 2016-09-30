---
title: "bindable"
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
  - "vc-attr.bindable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bindable attribute"
ms.assetid: a2360f92-927b-4af8-98cc-6eca7f4ec954
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bindable
Indicates that the property supports data binding.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The **bindable** C++ attribute has the same functionality as the [bindable](http://msdn.microsoft.com/library/windows/desktop/aa366738) MIDL attribute. You can use it on properties defined with the [propget](../vs140/propget.md), [propput](../vs140/propput.md), or [propputref](../vs140/propputref.md) attributes, or you can manually define a bindable method.  
  
 The following MFC samples show the use of **bindable**:  
  
-   [Controls Samples: MFC-Based ActiveX Controls](assetId:///a44adf86-0ba0-4504-bedb-512b6cba2e63)  
  
-   [CIRC Sample: ActiveX Control](assetId:///9ba34d04-280e-49f4-90ae-41a6be44c95b)  
  
-   [TESTHELP Sample: ActiveX Control with Tooltips and Help](assetId:///d822861d-c6f0-4d0a-ad11-970eebb1e8cd)  
  
## Example  
 The following code shows how you can use **bindable** on a property:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|Interface method|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information about the attribute contexts, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Method Attributes](../vs140/method-attributes.md)   
 [defaultbind](../vs140/defaultbind.md)   
 [displaybind](../vs140/displaybind.md)   
 [immediatebind](../vs140/immediatebind.md)   
 [requestedit](../vs140/requestedit.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)