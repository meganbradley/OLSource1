---
title: "Code Formatting Guidelines (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "formatting code [F#]"
  - "offside line [F#]"
  - "indenting code [F#]"
  - "code formatting [F#]"
ms.assetid: 29d3022c-3580-41aa-a754-6b5e53f32c2f
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Code Formatting Guidelines (F#)
This topic summarizes code indentation guidelines for F#. Because the F# language is sensitive to line breaks and indentation, it is not just a readability issue, aesthetic issue, or coding standardization issue to format your code correctly. You must format your code correctly for it to compile correctly.  
  
## General Rules for Indentation  
 When indentation is required, you must use spaces, not tabs. At least one space is required. Your organization can create coding standards to specify the number of spaces to use for indentation; three or four spaces of indentation at each level where indentation occurs is typical. You can configure [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] to match your organization's indentation standards by changing the options in the **Options** dialog box, which is available from the **Tools** menu. In the **Text Editor** node, expand **F#** and then click **Tabs**. For a description of the available options, see [Tabs, All Languages, Text Editor, Options Dialog Box](../vs140/options--text-editor--all-languages--tabs.md).  
  
 In general, when the compiler parses your code, it maintains an internal stack that indicates the current level of nesting. When code is indented, a new level of nesting is created, or pushed onto this internal stack. When a construct ends, the level is popped. Indentation is one way to signal the end of a level and pop the internal stack, but certain tokens also cause the level to be popped, such as the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> keyword, or a closing brace or parenthesis.  
  
 Code in a multiline construct, such as a type definition, function definition, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> construct, and looping constructs, must be indented relative to the opening line of the construct. The first indented line establishes a column position for subsequent code in the same construct. The indentation level is called a *context*. The column position sets a minimum column, referred to as an *offside line*, for subsequent lines of code that are in the same context. When a line of code is encountered that is indented less than this established column position, the compiler assumes that the context has ended and that you are now coding at the next level up, in the previous context. The term *offside* is used to describe the condition in which a line of code triggers the end of a construct because it is not indented far enough. In other words, code to the left of an offside line is offside. In correctly indented code, you take advantage of the offside rule in order to delineate the end of constructs. If you use indentation improperly, an offside condition can cause the compiler to issue a warning or can lead to the incorrect interpretation of your code.  
  
 Offside lines are determined as follows.  
  
-   An <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> token associated with a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> introduces an offside line at the column of the first token after the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> sign.  
  
-   In an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> expression, the column position of the first token after the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword or the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword introduces an offside line.  
  
-   In a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> expression, the first token after <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> introduces an offside line.  
  
-   In a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> expression, the first token after <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and the first token after each <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> introduce offside lines.  
  
-   The first token after <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> in a type extension introduces an offside line.  
  
-   The first token after an opening brace or parenthesis, or after the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> keyword, introduces an offside line.  
  
-   The first character in the keywords <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> introduce offside lines.  
  
 The following code examples illustrate the indentation rules. Here, the print statements rely on indentation to associate them with the appropriate context. Every time the indentation shifts, the context is popped and returns to the previous context. Therefore, a space is printed at the end of each iteration; "Done!" is only printed one time because the offside indentation establishes that it is not part of the loop. The printing of the string "Top-level context" is not part of the function. Therefore, it is printed first, during the static initialization, before the function is called.  
  
 [!code[FsCodeFormatting#1](../vs140/codesnippet/FSharp/code-formatting-guidelines--fsharp-_1.fs)]  
  
 The output is as follows.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 When you break long lines, the continuation of the line must be indented farther than the enclosing construct. For example, function arguments must be indented farther than the first character of the function name, as shown in the following code.  
  
 [!code[FsCodeFormatting#2](../vs140/codesnippet/FSharp/code-formatting-guidelines--fsharp-_2.fs)]  
  
 There are exceptions to these rules, as described in the next section.  
  
## Indentation in Modules  
 Code in a local module must be indented relative to the module, but code in a top-level module does not have to be indented. Namespace elements do not have to be indented.  
  
 The following code examples illustrate this.  
  
 [!code[FsCodeFormatting#3](../vs140/codesnippet/FSharp/code-formatting-guidelines--fsharp-_3.fs)]  
  
 [!code[FsCodeFormatting#4](../vs140/codesnippet/FSharp/code-formatting-guidelines--fsharp-_4.fs)]  
  
 For more information, see [Modules (F#)](../vs140/modules--fsharp-.md).  
  
## Exceptions to the Basic Indentation Rules  
 The general rule, as described in the previous section, is that code in multiline constructs must be indented relative to the indentation of the first line of the construct, and that the end of the construct is determined by when the first offside line occurs. An exception to the rule about when contexts end is that some constructs, such as the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> expression, the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> expression, and the use of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> syntax for declaring mutually recursive functions or types, have multiple parts. You indent the later parts, such as <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> in an <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> expression, at the same level as the token that starts the expression, but instead of indicating an end to the context, it represents the next part of the same context. Therefore, an <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> expression can be written as in the following code example.  
  
 [!code[FsCodeFormatting#5](../vs140/codesnippet/FSharp/code-formatting-guidelines--fsharp-_5.fs)]  
  
 The exception to the offside rule applies only to the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> keywords. Therefore, although it is not an error to indent the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> further, failing to indent the lines of code in a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> block produces a warning. This is illustrated in the following lines of code.  
  
 [!code[FsCodeFormatting#6](../vs140/codesnippet/FSharp/code-formatting-guidelines--fsharp-_6.fs)]  
  
 [!code[FsCodeFormatting#7](../vs140/codesnippet/FSharp/code-formatting-guidelines--fsharp-_7.fs)]  
  
 For code in an <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> block, an additional special rule applies. The warning in the previous example occurs only on the code in the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> block, not on the code in the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> block. This allows you to write code that checks for various conditions at the beginning of a function without forcing the rest of the code for the function, which might be in an <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> block, to be indented. Thus, you can write the following without producing a warning.  
  
 [!code[FsCodeFormatting#8](../vs140/codesnippet/FSharp/code-formatting-guidelines--fsharp-_8.fs)]  
  
 Another exception to the rule that contexts end when a line is not indented as far as a previous line is for infix operators, such as <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. Lines that start with infix operators are permitted to begin <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> columns before the normal position without triggering an end to the context, where <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is the number of characters that make up the operator. This causes the first token after the operator to align with the previous line.  
  
 For example, in the following code, the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> symbol is permitted to be indented two columns less than the previous line.  
  
 [!code[FsCodeFormatting#9](../vs140/codesnippet/FSharp/code-formatting-guidelines--fsharp-_9.fs)]  
  
 Although indentation usually increases as the level of nesting becomes higher, there are several constructs in which the compiler allows you to reset the indentation to a lower column position.  
  
 The constructs that permit a reset of column position are as follows:  
  
-   Bodies of anonymous functions. In the following code, the print expression starts at a column position that is farther to the left than the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> keyword. However, the line must not start at a column to the left of the start of the previous indentation level (that is, to the left of the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>).  
  
     [!code[FsCodeFormatting#10](../vs140/codesnippet/FSharp/code-formatting-guidelines--fsharp-_10.fs)]  
  
-   Constructs enclosed by parentheses or by <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> in a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> block of an <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> expression, provided the indentation is no less than the column position of the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> keyword. This exception allows for a coding style in which an opening parenthesis or <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is used at the end of a line after <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
-   Bodies of modules, classes, interfaces, and structures delimited by <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>. This allows for a style in which the opening keyword of a type definition can be on the same line as the type name without forcing the whole body to be indented farther than the opening keyword.  
  
     [!code[FsCodeFormatting#13](../vs140/codesnippet/FSharp/code-formatting-guidelines--fsharp-_11.fs)]  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)