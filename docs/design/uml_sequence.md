```mermaid
sequenceDiagram
    participant User
    participant ViewModel
    participant GeneticAlgorithm
    User ->> ViewModel: User clicks Generate
    ViewModel ->> GeneticAlgorithm: Calls RunEvolution
    GeneticAlgorithm ->> ViewModel: Returns List<Plan>
    ViewModel ->> User: Displays Best Plan
```
