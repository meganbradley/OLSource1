---
title: "Demo Sample"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "demo sample [Visual Studio ALM]"
  - "code analysis, samples"
ms.assetid: 09e1b9f7-5916-4ed6-a001-5c2d7e710682
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Demo Sample
This following procedures show you how to create the sample for [Walkthrough: Analyzing C/C++ Code for Defects](../vs140/walkthrough--analyzing-c-c---code-for-defects.md). The procedures create:  
  
-   A [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] solution named CppDemo.  
  
-   A static library project named CodeDefects.  
  
-   A static library project named Annotations.  
  
 The procedures also provide the code for the header and .cpp files for the static libraries.  
  
### Create the CppDemo solution and the CodeDefects project  
  
1.  Click the **File** menu, point to **New**, and then click **New Project**.  
  
2.  In the **Project types** tree list, if Visual C++ is not your default language in VS expand **Other Languages**.  
  
3.  Expand **Visual C++**, and then click **General**.  
  
4.  In **Templates**, click **Empty Project**.  
  
5.  In the **Name** text box, type **CodeDefects**.  
  
6.  Select the **Create directory for solution** check box.  
  
7.  In the **Solution Name** text box, type **CppDemo**.  
  
### Configure the CodeDefects project as a static library  
  
1.  In Solution Explorer, right-click **CodeDefects** and then click **Properties**.  
  
2.  Expand **Configuration Properties** and then click **General**.  
  
3.  In the **General** list, select the text in the column next to **Target Extension**, and then type **.lib**.  
  
4.  In **Project Defaults**, click the column next to **Configuration Type**, and then click **Static Lib (.lib)**.  
  
### Add the header and source file to the CodeDefects project  
  
1.  In Solution Explorer, expand **CodeDefects**, right-click **Header Files**, click **Add**, and then click **New Item**.  
  
2.  In the **Add New Item** dialog box, click **Code**, and then click **Header File (.h)**.  
  
3.  In the **Name** box, type **Bug.cpp** and then click **Add**.  
  
4.  Copy the following code and paste it into the **Bug.cpp** file in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] editor.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
5.  In Solution Explorer, right-click **Source Files**, point to **New**, and then click **New Item**.  
  
6.  In the **Add New Item** dialog box, click **C++ File (.cpp)**  
  
7.  In the **Name** box, type **Bug.cpp** and then click **Add**.  
  
8.  Copy the following code and paste it into the Bug.h file in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] editor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
9. Click the **File** menu, and then click **Save All**.  
  
### Add the Annotations project and configure it as a static library  
  
1.  In Solution Explorer, click **CppDemo**, point to **Add**, and then click **New Project**.  
  
2.  In the **Add New Project** dialog box, expand Visual C++, click **General**, and then click **Empty Project**.  
  
3.  In the **Name** text box, type **Annotations**, and then click **Add**.  
  
4.  In Solution Explorer, right-click **Annotations** and then click **Properties**.  
  
5.  Expand **Configuration Properties** and then click **General**.  
  
6.  In the **General** list, select the text in the column next to **Target Extension**, and then type **.lib**.  
  
7.  In **Project Defaults**, click the column next to **Configuration Type**, and then click **Static Lib (.lib)**.  
  
### Add the header file and source file to the Annotations project  
  
1.  In Solution Explorer, expand **Annotations**, right-click **Header Files**, click **Add**, and then click **New Item**.  
  
2.  In the **Add New Item** dialog box, click **Header File (.h)**.  
  
3.  In the **Name** box, type **annotations.h** and then click **Add**.  
  
4.  Copy the following code and paste it into the **annotations.h** file in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] editor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
5.  In Solution Explorer, right-click **Source Files**, point to **New**, and then click **New Item**.  
  
6.  In the **Add New Item** dialog box, click **Code** and then click **C++ File (.cpp)**  
  
7.  In the **Name** box, type **annotations.cpp** and then click **Add**.  
  
8.  Copy the following code and paste it into the **annotations.cpp** file in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] editor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
9. Click the **File** menu, and then click **Save All**.