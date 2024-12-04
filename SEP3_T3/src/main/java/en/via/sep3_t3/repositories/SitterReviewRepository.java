package en.via.sep3_t3.repositories;

import en.via.sep3_t3.domain.SitterReview;
import en.via.sep3_t3.repositoryContracts.ISitterReviewRepository;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.RowMapper;
import org.springframework.jdbc.support.GeneratedKeyHolder;
import org.springframework.jdbc.support.KeyHolder;
import org.springframework.stereotype.Repository;

import java.sql.*;
import java.time.ZoneId;
import java.time.ZonedDateTime;
import java.util.List;

@Qualifier("SitterReviewBase")
@Repository
public class SitterReviewRepository implements ISitterReviewRepository
{

  private final JdbcTemplate jdbcTemplate;

  public SitterReviewRepository(JdbcTemplate jdbcTemplate) {
    this.jdbcTemplate = jdbcTemplate;
  }

  public SitterReview findById(int id) {
    String sql = "SELECT * FROM Sitter_review WHERE id = ?";
    return jdbcTemplate.queryForObject(sql, new SitterReviewRowMapper(), id);
  }

  public List<SitterReview> findAll() {
    String sql = "SELECT * FROM Sitter_review";
    return jdbcTemplate.query(sql, new SitterReviewRowMapper());
  }

  public int save(SitterReview sitterReview) {
    KeyHolder keyHolder = new GeneratedKeyHolder();
    String sql = "INSERT INTO Sitter_review (owner_id, sitter_id, rating, comments, date) VALUES (?, ?, ?, ?, ?)";

    jdbcTemplate.update(connection -> {
      PreparedStatement ps = connection.prepareStatement(sql, Statement.RETURN_GENERATED_KEYS);
      ps.setInt(1, sitterReview.getOwner_id());
      ps.setInt(2, sitterReview.getSitter_id());
      ps.setInt(3, sitterReview.getRating());
      ps.setString(4, sitterReview.getComment());
      ps.setTimestamp(5, new Timestamp(
          ZonedDateTime.of(sitterReview.getDate(), ZoneId.systemDefault()).toInstant().getEpochSecond()));
      return ps;
    }, keyHolder);

    return (int) keyHolder.getKeys().get("id");
  }

  public void deleteById(int id) {
    String sql = "DELETE FROM Sitter_review WHERE id = ?";
    jdbcTemplate.update(sql, id);
  }

  private static class SitterReviewRowMapper implements RowMapper<SitterReview> {
    @Override
    public SitterReview mapRow(ResultSet rs, int rowNum) throws SQLException {
      SitterReview sitterReview = new SitterReview();
      sitterReview.setId(rs.getInt("id"));
      sitterReview.setOwner_id(rs.getInt("owner_id"));
      sitterReview.setSitter_id(rs.getInt("sitter_id"));
      sitterReview.setRating(rs.getInt("rating"));
      sitterReview.setComment(rs.getString("comments"));
      sitterReview.setDate(rs.getTimestamp("date").toLocalDateTime());
      return sitterReview;
    }
  }
}
