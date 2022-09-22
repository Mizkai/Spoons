-> main

=== main ===
Do you want to wash?

+ [Wash Face: -1 Spoon]
-> chose("washed your face! While you still feel tired, the cold water is energising and wakes you up +1 Health")

+ [Brush Teeth: -2 Spoons]
-> chose("brushed your Teeth! You felt gross before, but the minty clean feeling is refreshing. + 2 Health")

+ [Cancel]
-> chose("choose to save your energy")

=== chose(action) ===
You {action}.
-> END
