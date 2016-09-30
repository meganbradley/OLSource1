---
title: "HString Class"
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
  - "corewrappers/Microsoft::WRL::Wrappers::HString"
dev_langs: 
  - "C++"
ms.assetid: 6709dd2e-8d72-4675-8ec7-1baa7d71854d
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HString Class
Provides support for manipulating HSTRING handles.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] provides access to strings through HSTRING handles. The HString class provides convenience functions and operators to simplify using HSTRING handles.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[HString::HStringConstructor](../vs140/hstring--hstring-constructor.md)|Initializes a new instance of the HString class.|  
|[HString::~HStringConstructor](../vs140/hstring--~hstring-destructor.md)|Destroys the current instance of the HString class.|  
  
### Members  
  
|Name|Description|  
|----------|-----------------|  
|[HString::Set Method](../vs140/hstring--set-method.md)|Sets the value of the current HString object to the specified wide-character string or HString parameter.|  
|[HString::Attach Method](../vs140/hstring--attach-method.md)|Associates the specified HString object with the current HString object.|  
|[HString::CopyTo Method](../vs140/hstring--copyto-method.md)|Copies the current HString object to an HSTRING object.|  
|[HString::Detach Method](../vs140/hstring--detach-method.md)|Disassociates the specified HString object from its underlying value.|  
|[HString::GetAddressOf Method](../vs140/hstring--getaddressof-method.md)|Retrieves a pointer to the underlying HSTRING handle.|  
|[HString::Get Method](../vs140/hstring--get-method.md)|Retrieves the value of the underlying HSTRING handle.|  
|[HString::Release Method](../vs140/hstring--release-method.md)|Deletes the underlying string value and intializes the current HString object to an empty value.|  
|[HString::MakeReference Method](../vs140/hstring--makereference-method.md)|Creates an HStringReference object from a specified string parameter.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[operator=](../vs140/hstring--operator=-operator.md)|Moves the value of another HString object to the current HString object.|  
|[operator==](../vs140/hstring--operator==-operator.md)|Indicates whether the two parameters are equal.|  
|[operator!=](../vs140/hstring--operator!=-operator.md)|Indicates whether the two parameters are not equal.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [Wrappers Namespace](../vs140/microsoft--wrl--wrappers-namespace.md)