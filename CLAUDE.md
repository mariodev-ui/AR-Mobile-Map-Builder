# Spotstitch AR Engine — Project Memory

You are working on the Spotstitch AR game engine, a two-tier, cross-platform
augmented reality game-design studio.

## Product vision

Spotstitch is a creator-first AR platform. Creators use a browser-based
world-builder to design persistent, map-anchored AR experiences on real-world
geography. Players use a mobile AR app to discover and play those experiences.

## Tech stack

- Node services: Node.js 20 LTS, TypeScript 5.5+, Express 4.x, pnpm 9.x
- Database: MongoDB Atlas, Mongoose 8.x
- Auth: JWT (RS256)
- Web: Vite + React 18 + TypeScript + MapLibre GL JS
- Mobile AR: Unity 6 LTS, AR Foundation 6.x
- CV: Python 3.12, FastAPI, PyTorch + YOLO
- Docker, Kubernetes, Terraform

## Security rules

1. No secrets in source.
2. Every protected endpoint requires a valid JWT.
3. Every endpoint enforces ownership.
4. Every state-changing endpoint is server-authoritative.
5. All input is validated with Zod or Pydantic.
