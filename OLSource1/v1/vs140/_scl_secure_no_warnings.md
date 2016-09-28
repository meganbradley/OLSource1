---
title: "_SCL_SECURE_NO_WARNINGS"
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
  - "_SCL_SECURE_NO_DEPRECATE"
  - "_SCL_SECURE_NO_WARNINGS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_SCL_SECURE_NO_DEPRECATE"
  - "_SCL_SECURE_NO_WARNINGS"
ms.assetid: ef0ddea9-7c62-4b53-8b64-5f4fd369776f
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _SCL_SECURE_NO_WARNINGS
Calling any one of the potentially unsafe methods in the Standard C++ Library will result in [Compiler Warning (level 1) C4996](../vs140/compiler-warning--level-3--c4996.md). To disable this warning, define the macro **_SCL_SECURE_NO_WARNINGS** in your code:  
  
```  
#define _SCL_SECURE_NO_WARNINGS  
```  
  
## Remarks  
 Other ways to disable warning C4996 include:  
  
-   Using the [/D (Preprocessor Definitions)](../vs140/-d--preprocessor-definitions-.md) compiler option:  
  
    ```  
    cl /D_SCL_SECURE_NO_WARNINGS [other compiler options] myfile.cpp  
    ```  
  
-   Using the [/w](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md) compiler option:  
  
    ```  
    cl /wd4996 [other compiler options] myfile.cpp  
    ```  
  
-   Using the [#pragma warning](../vs140/warning.md) directive:  
  
    ```  
    #pragma warning(disable:4996)  
    ```  
  
 Also, you can manually change the level of warning C4996 with the **/w<l\><n\>** compiler option. For example, to set warning C4996 to level 4:  
  
```  
cl /w44996 [other compiler options] myfile.cpp  
```  
  
 For more information, see [/w, /Wn, /WX, /Wall, /wln, /wdn, /wen, /won (Warning Level)](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md).  
  
## See Also  
 [Safe Libraries: Standard C++ Library](../vs140/safe-libraries--c---standard-library.md)