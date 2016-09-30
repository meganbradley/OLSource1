---
title: "CAtlTransactionManager::CreateFile"
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
  - "atltransactionmanager/CAtlTransactionManager::CreateFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateFile"
ms.assetid: d7e67171-769c-42e9-a4a5-ee53e4983227
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTransactionManager::CreateFile
Creates or opens a file, file stream, or directory as a transacted operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The name of an object to be created or opened.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The access to the object, which can be summarized as read, write, both, or neither (zero). The most commonly used values are GENERIC_READ, GENERIC_WRITE, or both: GENERIC_READ &#124; GENERIC_WRITE.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The sharing mode of an object, which can be read, write, both, delete, all of these, or none: 0, FILE_SHARE_DELETE, FILE_SHARE_READ, FILE_SHARE_WRITE.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a SECURITY_ATTRIBUTES structure that contains an optional security descriptor and also determines whether or not the returned handle can be inherited by child processes. The parameter can be <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 An action to take on files that exist and do not exist. This parameter must be one of the following values, which cannot be combined: CREATE_ALWAYS, CREATE_NEW, OPEN_ALWAYS, OPEN_EXISTING, or TRUNCATE_EXISTING.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The file attributes and flags. This parameter can include any combination of the available file attributes (FILE_ATTRIBUTE_*). All other file attributes override FILE_ATTRIBUTE_NORMAL. This parameter can also contain combinations of flags (FILE_FLAG_\*) for control of buffering behavior, access modes, and other special-purpose flags. These combine with any FILE_ATTRIBUTE_\* values.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A valid handle to a template file with the GENERIC_READ access right. The template file supplies file attributes and extended attributes for the file that is being created. This parameter can be <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns a handle that can be used to access the object.  
  
## Remarks  
 This wrapper calls the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function.  
  
## Requirements  
 **Header:** atltransactionmanager.h  
  
## See Also  
 [CAtlTransactionManager Class](../vs140/catltransactionmanager-class.md)