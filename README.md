# Laboratorium 3 - Programowanie Wielowątkowe .NET

> Autor: Adrian Goral
> 
> Zadanie wykonane w ramach zajęć na Politechnice Wrocławskiej.

## Zadania do wykonania
1. Wysokopoziomowe mnożenie macierzy z wykorzystaniem `Parallel`.
2. Niskopoziomowe mnożenie macierzy z wykorzystaniem `Thread`.
3. Przetwarzanie obrazu z GUI (Windows Forms)

## Testy z zadania 1 i 2

Wykonanych zostało 10 testów dla każdej permutacji podanych parametrów:
```cs
int[] sizes = { 200, 500, 1000 };
int[] threadCounts = { 1, 2, 4, 6, 8, 10, 12, 16 };
```

Testy odbyły się na dwóch komputerach:
- Komputer 1 (`EDDY`):
  - Procesor: Intel Core i5-1035G1 @ 1.00GHz ; 4 rdzenie, 8 wątków
  - RAM: 8GB
  - System: Windows 11 Home 64-bit
- Komputer 2 (`AMG`):
  - Procesor: Intel Core i5-10400 @ 2.90GHz ; 6 rdzenie, 12 wątków
  - RAM: 32GB
  - System: Windows 11 Pro 64-bit

### Komputer 1 (`EDDY`)

Tak przeglądają wyniki testów na komputerze 1: