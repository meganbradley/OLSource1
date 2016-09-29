---
title: "How to: Use Extensions in a LightSwitch Project"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "extensions [Visual Studio LightSwitch]"
  - "extensions tab [Visual Studio LightSwitch]"
ms.assetid: ac8a9e18-5081-4875-81df-525154d92a67
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use Extensions in a LightSwitch Project
You use different types of extensions in different ways. Custom data type extensions appear in the **Type** list in the Data designer when you choose a compatible data type. For example, the `Image` custom data type extension becomes available when you choose the `Binary` data type.  
  
 Custom control extensions appear in **Screen Content Tree** lists in the Screen designer. For example, a custom `Masked Edit` control appears wherever a **TextBox** is available. The following procedures describe how to use theme and shell extensions.  
  
> [!NOTE]
>  Extensions are only available in Silverlight client projects.  
  
 Extensions are available only if they're enabled in the **Extensions** tab of the Application designer. See [How to: Add or Remove Extensions](../vs140/how-to--add-or-remove-extensions.md).  
  
### To apply a theme extension  
  
1.  In **Solution Explorer**, open the shortcut menu for the **Properties** node, and then choose **Open**.  
  
     In the Application designer, choose the **General Properties** tab, and then choose the **Edit Client properties** link.  
  
2.  In the **Theme** list, choose the extension that you want to apply.  
  
### To apply a shell extension  
  
1.  In the Client designer, choose the **Client Properties** tab, open the **Shell** list, and then choose the extension that you want to apply.  
  
## See Also  
 [Extensions: Adding New Capabilities to LightSwitch](../vs140/extensions--adding-new-capabilities-to-lightswitch.md)   
 [How to: Add or Remove Extensions](../vs140/how-to--add-or-remove-extensions.md)