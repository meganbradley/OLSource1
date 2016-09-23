---
title: "Important Commands for Language Service Filters"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - language services, filters
  - language services, commands to support
ms.assetid: 4948c494-3d4d-4f50-b3f9-959e73f90e4d
caps.latest.revision: 18
translation.priority.mt: 
  - de-de
  - ja-jp
---
# Important Commands for Language Service Filters
If you want to create a fully featured language service filter, consider handling the following commands. The full list of command identifiers is defined in the <xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID?qualifyHint=False> enumeration for managed code and the Stdidcmd.h header file for unmanaged [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] code. You can find the Stdidcmd.h file in *Visual Studio SDK installation path*\VisualStudioIntegration\Common\Inc.  
  
## Commands to Handle  
  
> [!NOTE]
>  It is not mandatory to filter for every command in the following table.  
  
|Command|Description|  
|-------------|-----------------|  
|<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID.SHOWCONTEXTMENU?qualifyHint=False>|Sent when the user right-clicks. This command indicates that it is time to provide a shortcut menu. If you do not handle this command, the text editor provides a default shortcut menu without any language-specific commands. To include your own commands on this menu, handle the command and display a shortcut menu yourself.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID.SHOWMEMBERLIST?qualifyHint=False>|Typically sent when the user types CTRL+J. Call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.UpdateCompletionStatus?qualifyHint=False> method on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView?qualifyHint=False> to show the statement completion box.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID.TYPECHAR?qualifyHint=False>|Sent when the user types a character. Monitor this command to determine when a trigger character is typed and to provide statement completion, method tips, and text markers, such as syntax coloring, brace matching, and error markers. Call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.UpdateCompletionStatus?qualifyHint=False> method on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView?qualifyHint=False> for statement completion and the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodTipWindow.SetMethodData?qualifyHint=False> method on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodTipWindow?qualifyHint=False> for method tips. To support text markers, monitor this command to determine whether the character being typed requires that you update your markers.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID.RETURN?qualifyHint=False>|Sent when the user types the Enter key. Monitor this command to determine when to dismiss a method tip window by calling the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData.OnDismiss?qualifyHint=False> method on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData?qualifyHint=False>. By default, the text view handles this command.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID.BACKSPACE?qualifyHint=False>|Sent when the user types the Backspace key. Monitor to determine when to dismiss a method tip window by calling the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData.OnDismiss?qualifyHint=False> method on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsMethodData?qualifyHint=False>. By default, the text view handles this command.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID.PARAMINFO?qualifyHint=False>|Sent from a menu or a shortcut key. Call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.UpdateTipWindow?qualifyHint=False> method on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView?qualifyHint=False> to update the tip window with the parameter information.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID.QUICKINFO?qualifyHint=False>|Sent when the user hovers over a variable or positions the cursor on a variable and selects **Quick Info** from **IntelliSense** in the **Edit** menu. Return the type of the variable in a tip by calling the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.UpdateTipWindow?qualifyHint=False> method on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView?qualifyHint=False>. If debugging is active, the tip should also show the value of the variable.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID.COMPLETEWORD?qualifyHint=False>|Typically sent when the user types CTRL+SPACEBAR. This command tells the language service to call the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView.UpdateCompletionStatus?qualifyHint=False> method on the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView?qualifyHint=False>.|  
|<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID.COMMENT_BLOCK?qualifyHint=False><br /><br /> <xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID.UNCOMMENT_BLOCK?qualifyHint=False>|Sent from a menu, typically **Comment Selection** or **Uncomment Selection** from **Advanced** in the **Edit** menu. <xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID.COMMENT_BLOCK?qualifyHint=False> indicates that the user wants to comment out the selected text; <xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID.COMMENT_BLOCK?qualifyHint=False> indicates that the user wants to uncomment the selected text. These commands can be implemented only by the language service.|  
  
## See Also  
 [Developing a Legacy Language Service](../vs140/developing-a-legacy-language-service.md)