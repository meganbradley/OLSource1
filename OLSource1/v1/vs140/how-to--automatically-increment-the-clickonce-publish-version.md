---
title: "How to: Automatically Increment the ClickOnce Publish Version"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "deploying applications [ClickOnce], incrementing publish version automatically"
  - "Publish Version property, incrementing"
  - "ClickOnce deployment, incrementing publish version automatically"
  - "publishing, ClickOnce"
ms.assetid: 686ab88a-6305-4914-a05b-fe269cc0ae1e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Automatically Increment the ClickOnce Publish Version
When publishing a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application, changing the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> property causes the application to be published as an update. By default, Visual Studio automatically increments the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> number of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> each time you publish the application.  
  
 You can disable this behavior on the **Publish** page of the **Project Designer**.  
  
> [!NOTE]
>  The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
### To disable automatically incrementing the Publish Version  
  
1.  With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.  
  
2.  Click the **Publish** tab.  
  
3.  In the **Publish Version** section, clear the **Automatically increment revision with each release** check box.  
  
## See Also  
 [How to: Set the ClickOnce Publish Version](../vs140/how-to--set-the-clickonce-publish-version.md)   
 [Publishing ClickOnce Applications](../vs140/publishing-clickonce-applications.md)   
 [How to: Publish a ClickOnce Application](../vs140/how-to--publish-a-clickonce-application-using-the-publish-wizard.md)