# dotnet 7 ref assemblies in F#

Problem case: when a new type is adding to the implementation file, the mvid guid changes.
As the new type is not added to the signature, I would not expect the mvid to change.

## Steps to reproduce

- Build the project
- Run the `mvid-reader.fsx` script
- Save guid 1
- Uncomment the `type W` in `Stuff.fs`
- Build the project
- Run the `mvid-reader.fsx` script
- Compare guid 2 with guid 1 => they differ 😔
