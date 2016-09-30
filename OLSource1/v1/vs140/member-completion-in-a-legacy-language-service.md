---
title: "Member Completion in a Legacy Language Service"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IntelliSense, Member Completion tool tip"
  - "Member Completion, supporting in language services [managed package framework]"
  - "language services [managed package framework], IntelliSense Member Completion"
ms.assetid: 500f718d-9028-49a4-8615-ba95cf47fc52
caps.latest.revision: 25
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Member Completion in a Legacy Language Service
The IntelliSense Member Completion is a tool tip that displays a list of possible members of a particular scope such as a class, structure, enumeration, or namespace. For example, in C#, if the user types "this" followed by a period, a list of all members of the class or structure at the current scope is presented in a list from which the user can select.  
  
 The managed package framework (MPF) provides support for the tool tip and managing the list in the tool tip; all that is needed is cooperation from the parser to supply the data that appears in the list.  
  
 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more, see [Extending the Editor](../vs140/extending-the-editor-and-language-services.md).  
  
> [!NOTE]
>  We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.  
  
## How It Works  
 The following are the two ways in which a member list is shown using the MPF classes:  
  
-   Positioning the caret on an identifier or after a member completion character and selecting **List Members** from the **IntelliSense** menu.  
  
-   The \<xref:Microsoft.VisualStudio.Package.IScanner*> scanner detects a member completion character and sets a token trigger of \<xref:Microsoft.VisualStudio.Package.TokenTriggers.MemberSelect*> for that character.  
  
 A member completion character indicates that a member of a class, structure, or enumeration is to follow. For example, in C# or Visual Basic the member completion character is a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, while  in C++ the character is either a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The trigger value is set when the member select character is scanned.  
  
### The IntelliSense Member List Command  
 The \<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID.SHOWMEMBERLIST*> command initiates a call to the \<xref:Microsoft.VisualStudio.Package.Source.Completion*> method on the \<xref:Microsoft.VisualStudio.Package.Source*> class and the \<xref:Microsoft.VisualStudio.Package.Source.Completion*> method, in turn, calls the \<xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource*> method parser with the parse reason of \<xref:Microsoft.VisualStudio.Package.ParseReason.DisplayMemberList*>.  
  
 The parser determines the context of the current position as well as the token under or immediately before the current position. Based on this token, a list of declarations is presented. For example, in C#, if you position the caret on a class member and select **List Members**, you get a list of all members of the class. If you position the caret after a period that follows an object variable, you get a list of all members of the class that object represents. Note that if the caret is positioned on a member when the member list is shown, selecting a member from the list replaces the member the caret is on with the one in the list.  
  
### The Token Trigger  
 The \<xref:Microsoft.VisualStudio.Package.TokenTriggers.MemberSelect*> trigger initiates a call to the \<xref:Microsoft.VisualStudio.Package.Source.Completion*> method on the \<xref:Microsoft.VisualStudio.Package.Source*> class and the \<xref:Microsoft.VisualStudio.Package.Source.Completion*> method, in turn, calls the parser with the parse reason of \<xref:Microsoft.VisualStudio.Package.ParseReason.MemberSelect*> (if the token trigger also included the \<xref:Microsoft.VisualStudio.Package.TokenTriggers.MatchBraces*> flag, the parse reason is \<xref:Microsoft.VisualStudio.Package.ParseReason.MemberSelectAndHighlightBraces*> which combines member selection and brace highlighting).  
  
 The parser determines the context of the current position as well as what has been typed before the member select character. From this information, the parser creates a list of all members of the requested scope. This list of declarations is stored in the \<xref:Microsoft.VisualStudio.Package.AuthoringScope*> object that is returned from the \<xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource*> method. If any declarations are returned, the member completion tool tip is displayed. The tool tip is managed by an instance of the \<xref:Microsoft.VisualStudio.Package.CompletionSet*> class.  
  
## Enabling Support for Member Completion  
 You must have the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> registry entry set to 1 to support any IntelliSense operation. This registry entry can be set with a named parameter passed to the \<xref:Microsoft.VisualStudio.Shell.ProvideLanguageServiceAttribute*> user attribute associated with the language package. The language service classes read the value of this registry entry from the \<xref:Microsoft.VisualStudio.Package.LanguagePreferences.EnableCodeSense*> property on the \<xref:Microsoft.VisualStudio.Package.LanguagePreferences*> class.  
  
 If your scanner returns the token trigger of \<xref:Microsoft.VisualStudio.Package.TokenTriggers.MemberSelect*>, and your parser returns a list of declarations, then the member completion list is displayed.  
  
## Supporting Member Completion in the Scanner  
 The scanner must be able to detect a member completion character and set the token trigger of \<xref:Microsoft.VisualStudio.Package.TokenTriggers.MemberSelect*> when that character is parsed.  
  
### Example  
 Here is a simplified example of detecting the member completion character and setting the appropriate \<xref:Microsoft.VisualStudio.Package.TokenTriggers*> flag. This example is for illustrative purposes only. It assumes that your scanner contains a method <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that identifies and returns tokens from a line of text. The example code simply sets the trigger whenever it sees the right kind of character.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Supporting Member Completion in the Parser  
 For member completion, the \<xref:Microsoft.VisualStudio.Package.Source*> class calls the \<xref:Microsoft.VisualStudio.Package.AuthoringScope.GetDeclarations*> method. You must implement the list in a class that is derived from the \<xref:Microsoft.VisualStudio.Package.Declarations*> class. See the \<xref:Microsoft.VisualStudio.Package.Declarations*> class for details about the methods you must implement.  
  
 The parser is called with \<xref:Microsoft.VisualStudio.Package.ParseReason.MemberSelect*> or \<xref:Microsoft.VisualStudio.Package.ParseReason.MemberSelectAndHighlightBraces*> when a member select character is typed. The location given in the \<xref:Microsoft.VisualStudio.Package.ParseRequest*> object is immediately after the member select character. The parser must collect the names of all members that can appear in a member list at that particular point in the source code. Then the parser must parse the current line to determine the scope the user wants associated with the member select character.  
  
 This scope is based on the type of the identifier before the member select character. For example, in C#, given the member variable <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that has a type of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, typing **languageService.** produces a list of all the members of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class. Also in C#, typing **this.** produces a list of all the members of the class in the current scope.  
  
### Example  
 The following example shows one way to populate a \<xref:Microsoft.VisualStudio.Package.Declarations*> list. This code assumes that the parser constructs a declaration and adds it to the list by calling an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method on the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>