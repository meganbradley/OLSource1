---
title: "CSecurityAttributes Class"
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
  - "ATL.CSecurityAttributes"
  - "ATL::CSecurityAttributes"
  - "CSecurityAttributes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSecurityAttributes class"
ms.assetid: a094880c-52e1-4a28-97ff-752d5869908e
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSecurityAttributes Class
This class is a thin wrapper for the security attributes structure.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CSecurityAttributes::CSecurityAttributes](../vs140/csecurityattributes--csecurityattributes.md)|The constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSecurityAttributes::Set](../vs140/csecurityattributes--set.md)|Call this method to set the attributes of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 The **SECURITY_ATTRIBUTES** structure contains a [security descriptor](http://msdn.microsoft.com/library/windows/desktop/aa379561) used for the creation of an object and specifies whether the handle retrieved by specifying this structure is inheritable.  
  
 For an introduction to the access control model in Windows, see [Access Control](http://msdn.microsoft.com/library/windows/desktop/aa374860) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlsecurity.h  
  
##  \<a name="csecurityattributes__csecurityattributes">\</a>  CSecurityAttributes::CSecurityAttributes  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Reference to a security descriptor.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies whether the returned handle is inherited when a new process is created. If this member is true, the new process inherits the handle.  
  
##  \<a name="csecurityattributes__set">\</a>  CSecurityAttributes::Set  
 Call this method to set the attributes of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Reference to a security descriptor.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Specifies whether the returned handle is inherited when a new process is created. If this member is true, the new process inherits the handle.  
  
### Remarks  
 This method is used by the constructor to initialize the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
## See Also  
 [Security Sample](../vs140/visual-c---samples.md)   
 [SECURITY_ATTRIBUTES](http://msdn.microsoft.com/library/windows/desktop/aa379560)   
 [security descriptor](http://msdn.microsoft.com/library/windows/desktop/aa379561)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [Security Global Functions](../vs140/security-global-functions.md)