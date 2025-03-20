DO $$
BEGIN
IF NOT EXISTS (
    SELECT 1
    FROM pg_indexes
    WHERE schemaname = 'public' AND indexname = 'warehouse_index' AND tablename = 'stock'
)
THEN
    CREATE INDEX warehouse_index ON stock (w_id) ;
END IF;
END $$;