# Write your MySQL query statement below
WITH FriendCounts AS (
    SELECT
        user_id AS id,
        COUNT(DISTINCT friend_id) AS num
    FROM (
        SELECT requester_id AS user_id, accepter_id AS friend_id FROM RequestAccepted
        UNION ALL
        SELECT accepter_id AS user_id, requester_id AS friend_id FROM RequestAccepted
    ) AS friendships
    GROUP BY user_id
)
SELECT id, num
FROM FriendCounts
ORDER BY num DESC
LIMIT 1;
