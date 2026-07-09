#!/usr/bin/env bash
set -e

if [ -z "$1" ]; then
  echo "Usage: ./commit.sh \"commit message\""
  exit 1
fi

git add -A
git commit -m "$*"
git push
