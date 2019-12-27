# Dev Notes

## Resource Nodes
Seraphendipity | 22.12.2019

Resource Nodes spawns a random number of game objects around it, allowing setting up "nodes" of resources like patches of trees or gold.

The fun part is the recursion -- to set up patches of gold spots around the map, there is a resource node that has a resource node of items as its input, thus it spanws those resource nodes which then spawn the items.