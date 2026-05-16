# DSA From Scratch — C# & .NET

A personal learning repository where I implement every data structure and algorithm from scratch in C#, without using `System.Collections.Generic`. The goal is to build deep understanding of how these structures work internally before relying on .NET's native implementations.

## What this is

This is not a library. It's a structured 17-week study plan translated into code — each implementation comes with unit tests, complexity analysis, and stress tests that validate correctness at scale.

## Project structure

```
DSA-From-Scratch/
├── src/
│   ├── DSA.Structures/       # All data structure implementations
│   │   ├── Linear/           # Array, Linked List, Stack, Queue, Hash Table
│   │   ├── Trees/            # BST, AVL Tree, Heap
│   │   └── Graphs/           # Graph (Adjacency List)
│   └── DSA.Algorithms/       # Sorting and searching algorithms
└── tests/
    └── DSA.Tests/            # xUnit tests for every structure
```

## Progress

### Phase 1 — Linear Structures
| Structure | Implemented | Stress Tested | Complexity |
|---|---|---|---|
| Dynamic Array | ⬜ | ⬜ | Add O(1) amortized, Search O(n) |
| Singly Linked List | ⬜ | ⬜ | Insert O(1), Search O(n) |
| Doubly Linked List | ⬜ | ⬜ | Insert O(1), RemoveLast O(1) |
| Stack | ⬜ | ⬜ | Push/Pop O(1) |
| Queue (circular array) | ⬜ | ⬜ | Enqueue/Dequeue O(1) |
| Hash Table | ⬜ | ⬜ | Get/Insert O(1) avg |

### Phase 2 — Hierarchical Structures
| Structure | Implemented | Stress Tested | Complexity |
|---|---|---|---|
| Binary Search Tree | ⬜ | ⬜ | Search O(log n) avg, O(n) worst |
| AVL Tree | ⬜ | ⬜ | Search/Insert O(log n) guaranteed |
| Min Heap | ⬜ | ⬜ | Insert O(log n), ExtractMin O(log n) |

### Phase 3 — Graphs & Algorithms
| Structure / Algorithm | Implemented | Stress Tested | Complexity |
|---|---|---|---|
| Graph (Adjacency List) | ⬜ | ⬜ | AddEdge O(1), GetNeighbors O(k) |
| BFS | ⬜ | ⬜ | O(V + E) |
| DFS | ⬜ | ⬜ | O(V + E) |
| Merge Sort | ⬜ | ⬜ | O(n log n), Space O(n) |
| Quick Sort | ⬜ | ⬜ | O(n log n) avg, O(n²) worst |
| Heap Sort | ⬜ | ⬜ | O(n log n), Space O(1) |

## Rules I follow

- **No `System.Collections.Generic` in `/src`** — only primitive arrays `T[]` and custom classes
- **Every structure has stress tests** — correctness is validated at 10k–1M elements
- **Complexity is documented** — every public method has a comment with its Big-O analysis
- **Daily commits** — the commit history reflects the learning process

## Stack

- .NET 10
- C# 13
- xUnit for testing
- Rider as IDE

## Running the tests

```bash
dotnet test
```

