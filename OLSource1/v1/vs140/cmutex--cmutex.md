---
title: "CMutex::CMutex"
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
  - "CMutex::CMutex"
  - "CMutex.CMutex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMutex class, constructor"
  - "CMutex constructor"
ms.assetid: 4bee3f91-eea4-4a89-8058-8c61bb74eb24
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMutex::CMutex
Constructs a named or unnamed <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies if the thread creating the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object initially has access to the resource controlled by the mutex.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Name of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object. If another mutex with the same name exists, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> must be supplied if the object will be used across process boundaries. If **NULL**, the mutex will be unnamed. If the name matches an existing mutex, the constructor builds a new <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object which references the mutex of that name. If the name matches an existing synchronization object that is not a mutex, the construction will fail.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Security attributes for the mutex object. For a full description of this structure, see [SECURITY_ATTRIBUTES](http://msdn.microsoft.com/library/windows/desktop/aa379560) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 To access or release a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object, create a [CMultiLock](../vs140/cmultilock-class.md) or [CSingleLock](../vs140/csinglelock-class.md) object and call its [Lock](../vs140/csinglelock--lock.md) and [Unlock](../vs140/csinglelock--unlock.md) member functions. If the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object is being used stand-alone, call its <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> member function to release it.  
  
> [!IMPORTANT]
>  After creating the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object, use [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) to ensure that the mutex did not already exist. If the mutex did exist unexpectedly, it may indicate a rogue process is squatting and may be intending to use the mutex maliciously. In this case, the recommended security-conscious procedure is to close the handle and continue as if there was a failure in creating the object.  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CMutex Class](../vs140/cmutex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)