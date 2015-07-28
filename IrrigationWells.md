# Introduction #

The MikeShe editor cannot handle models with more than ~50 irrigation wells because a new node in the tree view is created for every irrigation wells.

This project handles this by reading the irrigation wells from a shape file and inserting them into the .she-file. Subsequently the model can be preprocessed and run and when the model is finished the irrigation wells are removed from the .she-file so the file can again be opened with the editor


# Details #