---
title: "Using the MFC Source Files"
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
helpviewer_keywords: 
  - "public members"
  - "source files"
  - "MFC, source files"
  - "MFC source files"
  - "comments, MFC"
  - "private member access"
  - "protected member access"
  - "source files, MFC"
ms.assetid: 3230e8fb-3b69-4ddf-9538-365ac7ea5e72
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using the MFC Source Files
The Microsoft Foundation Class (MFC) Library supplies full source code. Header files (.h) are in the \atlmfc\include directory; implementation files (.cpp) are in the \atlmfc\src\mfc directory.  
  
 This family of articles explains the conventions that MFC uses to comment the various parts of each class, what these comments mean, and what you should expect to find in each section. The Visual C++ wizards use similar conventions for the classes that they create for you, and you will probably find these conventions useful for your own code.  
  
 You might be familiar with the **public**, `protected`, and `private` C++ keywords. When looking at the MFC header files, you will find that each class may have several of each of these. For example, public member variables and functions might be under more than one **public** keyword. This is because MFC separates member variables and functions based on their use, not by the type of access allowed. MFC uses `private` sparingly; even items considered implementation details are generally protected and many times are public. Although access to the implementation details is discouraged, MFC leaves the decision to you.  
  
 In both the MFC source files and the files that the MFC Application Wizard creates, you will find comments like these within class declarations (usually in this order):  
  
 `// Constructors`  
  
 `// Attributes`  
  
 `// Operations`  
  
 `// Overridables`  
  
 `// Implementation`  
  
 Topics covered in this family of articles include:  
  
-   [An example of the comments](../vs140/an-example-of-the-comments.md)  
  
-   [The // Implementation comment](../vs140/---implementation-comment.md)  
  
-   [The // Constructors comment](../vs140/---constructors-comment.md)  
  
-   [The // Attributes comment](../vs140/---attributes-comment.md)  
  
-   [The // Operations comment](../vs140/---operations-comment.md)  
  
-   [The // Overridables comment](../vs140/---overridables-comment.md)  
  
## See Also  
 [General MFC Topics](../vs140/general-mfc-topics.md)