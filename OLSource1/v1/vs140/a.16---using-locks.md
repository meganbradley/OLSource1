---
title: "A.16   Using Locks"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 873bf32b-6cfe-4ce1-b994-bef80b50f399
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# A.16   Using Locks
In the following example, (for [Section 3.2](../vs140/3.2-lock-functions.md) on page 41) note that the argument to the lock functions should have type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, and that there is no need to flush it.  The lock functions cause the threads to be idle while waiting for entry to the first critical section, but to do other work while waiting for entry to the second.  The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function blocks, but the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function does not, allowing the work in skip() to be done.  
  
## Example  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>