---
title: "CDacl::AddAllowedAce"
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
  - "AddAllowedAce"
  - "CDacl.AddAllowedAce"
  - "CDacl::AddAllowedAce"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddAllowedAce method"
ms.assetid: 2c377c42-df8b-4a95-920c-edf6676ec5f2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDacl::AddAllowedAce
Adds an allowed ACE (access-control entry) to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A [CSid](../vs140/csid-class.md) object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the mask of access rights to be allowed for the specified <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A set of bit flags that control ACE inheritance.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The object type.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The inherited object type.  
  
## Return Value  
 Returns **true** if the ACE is added to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object, **false** on failure.  
  
## Remarks  
 A <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object contains zero or more ACEs (access-control entries) that identify the users and groups who can access the object. This method adds an ACE that allows access to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
> [!NOTE]
>  The second form of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is only available on Windows 2000 and later.  
  
 See [ACE_HEADER](http://msdn.microsoft.com/library/windows/desktop/aa374919) for a description of the various flags which can be set in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter.  
  
## Requirements  
 **Header:** atlsecurity.h  
  
## See Also  
 [CDacl Class](../vs140/cdacl-class.md)   
 [CDacl::AddDeniedAce](../vs140/cdacl--adddeniedace.md)   
 [ACCESS_MASK](http://msdn.microsoft.com/library/windows/desktop/aa374892)